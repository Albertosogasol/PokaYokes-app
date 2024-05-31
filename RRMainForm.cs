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
        //Variables de clase
        private RedRabbit RRSelected; // Crear objetos de la clase RedRabbit
        public RRMainForm rrMainForm;

        public RRMainForm()
        {
            InitializeComponent(); //Inicializa el formulario
        }

        //Carga de DataGridView
        private void RRMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pokaYokesDataSet.T10RedRabbits' table. You can move, or remove it, as needed.
            this.t10RedRabbitsTableAdapter.Fill(this.pokaYokesDataSet.T10RedRabbits); //Rellena el DataGridView con los datos de la BBDD

        }

        //Doble click
        public void RRDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Al hacer doble click en algún RR de la DataGridView se cargan los valores en las casillas correspondientes
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

            //Se crea un nuevo objeto de la clave RedRabbit. Es una variable de clase declarada al principio del código
            RRSelected = new RedRabbit();

            //Asignación de valores a las propiedades del objeto
            RRSelected.rrNumber = RRDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            RRSelected.rrNumberIng = RRDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            RRSelected.rrDescription = RRDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            RRSelected.rrProject = RRDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            RRSelected.rrTech = RRDataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            RRSelected.rrReference = RRDataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            RRSelected.rrCreatedBy = RRDataGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            RRSelected.rrComments = RRDataGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
            RRSelected.rrMachine = RRDataGrid.Rows[e.RowIndex].Cells[9].Value.ToString();
            RRSelected.rrDate = RRDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            RRSelected.rrMonth = RRDataGrid.Rows[e.RowIndex].Cells[10].Value.ToString();
            RRSelected.rrCalibrationChk = Convert.ToBoolean(RRDataGrid.Rows[e.RowIndex].Cells[11].Value.ToString());
            RRSelected.rrNumberOriginal = RRSelected.rrNumber; //Valor oringial por si se cambia el número de RedRabbit en la modificación
            RRSelected.rrId = RRDataGrid.Rows[e.RowIndex].Cells[12].Value.ToString();

        }

        //Botón modificar
        private void RRModButton_Click(object sender, EventArgs e)
        {
        if (RRSelected != null)
            {
                //Instancia al formulario de editar RR
                var RRModForm = new RRModifyForm(RRSelected); //Se pasa como parámetro el objeto de la clase RedRabbit
                RRModForm.ShowDialog();
            }
        else
            {
                MessageBox.Show("Seleccione un registro antes de modificar.", "Seleccione un registro", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        //Botón cerrar
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método cerrar
        public void RRMainFormClose()
        {
            //Se usa para llamar al método desde otra clase
            this.Close();
        }

        //Botón añadir RedRabbit
        private void RRAddButton_Click(object sender, EventArgs e)
        {
            //Instancia al formulario de crear RR
            var RRAddFOrm = new RRAddForm();
            RRAddFOrm.ShowDialog();
        }

        //Actualización de DataGridView
        public void DataGridViewRefresh()
        {
            this.t10RedRabbitsTableAdapter.Update(this.pokaYokesDataSet.T10RedRabbits);
            //this.t10RedRabbitsTableAdapter.Fill(this.pokaYokesDataSet.T10RedRabbits);
        }
    }
}
