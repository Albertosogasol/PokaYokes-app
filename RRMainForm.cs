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
    public partial class RRMainForm : Form
    {
        public RRMainForm()
        {
            InitializeComponent();
        }

        private void RRMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pokaYokesDataSet.T20RedRabbits' table. You can move, or remove it, as needed.
            this.t20RedRabbitsTableAdapter.Fill(this.pokaYokesDataSet.T20RedRabbits);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
