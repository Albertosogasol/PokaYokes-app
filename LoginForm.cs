using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokaYokes_app
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            // Prueba de conexión con la base de datos
            if (MainFunctions.PokaYokesDbTest() == true) //Si el test devuelve error cerrar el programa
            {
                MessageBox.Show("El programa se cerrará", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
            else
            {
                // Si error = FALSE se continua con la inialización
                InitializeComponent();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // LOADER PRINCIPAL DE LA VENTAÑA DE LOGIN
            this.t0UsersTableAdapter.Fill(this.pokaYokesDataSet.T0Users); //Rellena la lista de usuarios

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
                    // string sqlQuery = "SELECT * FROM T0Users WHERE Id = 1";
                    string sqlQuery = "SELECT Id, type_Username, type_User, type_Password FROM T0Users WHERE Id = 1";
                    using (OleDbCommand cmd = new OleDbCommand(sqlQuery, conn))
                    {
                        conn.Open();
                        //Asignamos el parámetro a la consulta
                        // cmd.Parameters.AddWithValue("@Username", "gonzaga");

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

                                //Si las credenciales son correctas, se inicia el programa
                                if (userData.password == loginFormPasswdBox.Text)
                                {
                                    this.Hide();
                                    var mainForm = new MainForm(userData);
                                    mainForm.Show();
                                    //Application.Run(new MainForm());
                                }
                                else
                                {
                                    MessageBox.Show("Contraseña incorrecta!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    loginFormPasswdBox.Text = "";
                                }
                            }
                            else
                            {
                                MessageBox.Show("USARIO NO ENCONTRADO");
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
