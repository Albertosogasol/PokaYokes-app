using System;
using System.Data.OleDb;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;
namespace PokaYokes_app
{
    public partial class LoginForm : Form
    {
        // Variables de clase
        private UserVariables currentUser;
        
        public LoginForm()
        {
            // Prueba de conexión con la base de datos
            if (MainFunctions.PokaYokesDbTest() == true) // Si el test devuelve error, cerrar el programa
            {
                MessageBox.Show("El programa se cerrará", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
            else
            {
                // Si error = FALSE se continúa con la inicialización
                InitializeComponent();
            }
        }
        
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // LOADER PRINCIPAL DE LA VENTANA DE LOGIN
            this.t0UsersTableAdapter.Fill(this.pokaYokesDataSet.T0Users); // Rellena la lista de usuarios
        }
        
        private void LoginFormOkButton_Click(object sender, EventArgs e)
        {
            // REALIZA EL LOGUEO DEL USUARIO SELECCIONADO CON LA CONTRASEÑA ASIGNADA

            UserVariables userData = new UserVariables(); //Creación objeto de la clase UserVariables donde se almacenará la informacion del usuario

            // Conexión con la base de datos
            using (OleDbConnection conn = new OleDbConnection(MainFunctions.ConStringBuilder()))
            {
                try
                {
                    string selectedUser = this.loginFormUserComboBox.GetItemText(this.loginFormUserComboBox.SelectedItem); //Usuario seleccionado en el comboBox del formulario

                    //Consulta principal para buscar el usuario seleccionado en la base de datos.
                    string sqlQuery = "SELECT T0Users.*, T0Roles.type_Rol AS RoleName FROM T0Users INNER JOIN T0Roles ON T0Users.type_Rol = T0Roles.id_Rol WHERE T0Users.type_User = @typeUser";
                    //Explicación de la consulta:
                    
                    //  1. * *SELECT T0Users.*, T0Roles.type_Rol AS RoleName * *:
                    //   - `SELECT`: Es el comando que se usa para indicar que queremos seleccionar datos de la base de datos.
                    //   - `T0Users.*`: Selecciona todas las columnas de la tabla `T0Users`. El asterisco(`*`) es un comodín que indica "todas las columnas".
                    //   - `T0Roles.type_Rol AS RoleName`: Selecciona la columna `type_Rol` de la tabla `T0Roles` y le asigna un alias(`AS RoleName`).Este alias permite referirse a esta columna como `RoleName` en los resultados.
                    
                    //  2. * *FROM T0Users * *:
                    //   -Indica la tabla principal(`T0Users`) de la cual estamos seleccionando datos.
                    
                    //  3. * *INNER JOIN T0Roles ON T0Users.type_Roles = T0Roles.id_Roles * *:
                    //   - `INNER JOIN`: Especifica un tipo de combinación de tablas(join).Un `INNER JOIN` devuelve solo las filas que tienen coincidencias en ambas tablas.
                    //   - `T0Roles`: La tabla secundaria con la que se está combinando(`T0Users`).
                    //   - `ON T0Users.type_Rol = T0Roles.id_Roles`: Indica la condición de la combinación. En este caso, estamos uniendo las tablas `T0Users` y `T0Roles` donde el valor de `type_Roles` en `T0Users` coincide con el valor de `id_Rol` en `T0Roles`.

                    //  4. * *WHERE T0Users.type_User = @typeUser * *:
                    //   - `WHERE`: Filtra los resultados para incluir solo las filas que cumplen con una condición específica.
                    //   - `T0Users.type_User = @typeUser`: La condición de filtro. Solo se seleccionan las filas de `T0Users` donde `type_User` es igual al valor del parámetro `@typeUser`.


                    using (OleDbCommand cmd = new OleDbCommand(sqlQuery, conn))
                    {
                        conn.Open();
                        // Asignar el valor del parámetro
                        cmd.Parameters.AddWithValue("@typeUser", selectedUser);
                        // Ejecutar la consulta
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            // Verificar que se encontró el usuario
                            if (reader.Read())
                            {
                                // Obtener los valores de las demás columnas
                                userData.user = reader["type_User"].ToString();
                                userData.username = reader["type_Username"].ToString();
                                userData.password = reader["type_Password"].ToString();
                                userData.userRol = reader["RoleName"].ToString(); // Obtener el nombre del rol
                                                                                  // Si las credenciales son correctas, se inicia el programa
                                if (userData.password == loginFormPasswdBox.Text)
                                {
                                    this.Hide();
                                    var mainForm = new MainForm(userData);
                                    mainForm.Show();
                                    UserSession.CurrentUser = userData;
                                }
                                else
                                {
                                    MessageBox.Show("Contraseña incorrecta!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    loginFormPasswdBox.Text = "";
                                }
                            }
                            else
                            {
                                MessageBox.Show("USUARIO NO ENCONTRADO");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void loginFormExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
