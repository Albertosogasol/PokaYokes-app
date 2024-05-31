using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PokaYokes_app
{
    public partial class RRDelForm : Form
    {
        //Variables de clase
        private int idNumber;
        
        public RRDelForm(RedRabbit redRabbit)
        {
            InitializeComponent();
            FillBoxes(redRabbit);
        }

        //Rellena las textbox del formulario
        private void FillBoxes(RedRabbit redRabbit)
        {
            //Rellena los campos correspondientes con los atributos del objeto pasado por argumento
            NumTextBox.Text = MainFunctions.RRNumberTruncate(redRabbit.rrNumber); //Se acorta el número para eliminar la parte "RR-"
            NumberIngTextBox.Text = redRabbit.rrNumberIng;
            DescriptionTextBox.Text = redRabbit.rrDescription;
            ProjectTextBox.Text = redRabbit.rrProject;
            TechTextBox.Text = redRabbit.rrTech;
            RefTextBox.Text = redRabbit.rrReference;
            DatePicker.Text = redRabbit.rrDate;
            CreatedByTextBox.Text = redRabbit.rrCreatedBy;
            CommentsTextBox.Text = redRabbit.rrComments;
            MachineTextBox.Text = redRabbit.rrMachine;
            MonthComboBox.Text = redRabbit.rrMonth;
            RRIdTextBox.Text = redRabbit.rrId.ToString();
            idNumber = redRabbit.rrId;
        }

        //Botón eliminar
        private void delButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar el RedRabbit RR-" + NumTextBox.Text + " de la base de datos?.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show("El RedRabbit RR-" + NumTextBox.Text + " se eliminará definitivamente. ¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult2 == DialogResult.Yes)
                {
                    try
                    {
                        RedRabbitCRUD redRabbitCRUD = new RedRabbitCRUD();
                        redRabbitCRUD.DeleteRR(idNumber);
                        MessageBox.Show("RedRabbit eliminado con éxito. ", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        //Cerrar formulario
                        this.Close();

                        //Recarga del DataGridView
                        RRMainForm rrMainForm = new RRMainForm(); //Instancia a la clase RRMainForm
                        rrMainForm.RRMainFormClose(); //Se cierra el formulario
                        System.Threading.Thread.Sleep(2000);
                        RRMainForm rrMainFormReload = new RRMainForm(); //Nueva instancia a la clase RRMainForm
                        rrMainFormReload.ShowDialog(); //Se muestra el formulario
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en la ejecución del borrado. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
        }

        //Botón cerrar
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
