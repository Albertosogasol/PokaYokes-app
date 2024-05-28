using System;
using System.Data.OleDb;
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
            // Realiza el logueo del usuario seleccionado con la contraseña
            UserVariables userData = new UserVariables();
            // Conexión con la base de datos
            using (OleDbConnection conn = new OleDbConnection(MainFunctions.ConStringBuilder()))
            {
                try
                {
                    string selectedUser = this.loginFormUserComboBox.GetItemText(this.loginFormUserComboBox.SelectedItem);
                    string sqlQuery = "SELECT * FROM T0Users WHERE type_User = @typeUser";
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
