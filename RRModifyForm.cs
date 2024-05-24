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
    public partial class RRModifyForm : Form
    {
        //Variable de clase 
        private RedRabbit RRModify;
        
        public RRModifyForm(RedRabbit redRabbit)
        {
            InitializeComponent();
            RRModify = redRabbit;
            PonerDatos();
        }

        private void PonerDatos()
        {
            MessageBox.Show(RRModify.rrReference, RRModify.rrProject);
        }
    }
}
