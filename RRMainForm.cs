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
            // TODO: This line of code loads data into the 'pokaYokesDataSet.T10RedRabbits' table. You can move, or remove it, as needed.
            this.t10RedRabbitsTableAdapter.Fill(this.pokaYokesDataSet.T10RedRabbits);

        }

        private void RRDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RRNumberTextBox.Text = RRDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            RRNumberIngTextBox.Text = RRDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            RRDescriptionTextBox.Text = RRDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            RRProjectTextBox.Text = RRDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            RRTechTextBox.Text = RRDataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            RRRefTextBox.Text = RRDataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            RRCreatedByTextBox.Text = RRDataGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            RRCommentsTextBox.Text = RRDataGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
            RRMachineTextBox.Text = RRDataGrid.Rows[e.RowIndex].Cells[9].Value.ToString();
            RRDatePicker.Text = RRDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

        }
    }
}
