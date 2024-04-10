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


        }
    }
}
