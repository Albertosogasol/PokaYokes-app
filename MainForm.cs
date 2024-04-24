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
        public UserVariables userData;


        public MainForm(UserVariables userData)
        {
            InitializeComponent();
            this.userData = userData;
            MessageBox.Show(userData.user);
        }

        // Abrir formulario de modificación de RR
        private void RRFormButton_Click(object sender, EventArgs e)
        {
            var RRForm = new RRMainForm();
            RRForm.ShowDialog();
        }

    }


}
