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
        public MainForm()
        {
            InitializeComponent();
        }
        //Esto es un comentario general en la clase principal
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha pulsado el botón");
        }
    }
}
