using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokaYokes_app
{
    public partial class MainForm : Form
    {
        //Variables de clase
        public UserVariables userData;

        //Formulario principal
        public MainForm(UserVariables userData)
        {
            InitializeComponent();
            this.userData = userData;
            this.StartPosition = FormStartPosition.CenterScreen;
            FillUserBox();
        }

        // Abrir formulario de modificación de RR
        private void RRFormButton_Click(object sender, EventArgs e)
        {
            var RRForm = new RRMainForm();
            RRForm.ShowDialog();
        }

        //Cierra todo el programa
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Cambiar usuario Botón
        private void changeUserButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        //Datos usuario actual
        private void FillUserBox()
        {
            //Rellena los datos de los TextBoxes del formulario con el usuario actual
            userTextBox.Text = userData.user;
            roleTextBox.Text = userData.userRol;
        }
    }


}
