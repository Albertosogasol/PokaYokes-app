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
    public partial class RRAddForm : Form
    {
        //Variables de clase
        private RRMainForm currentRRMainForm;

        public RRAddForm(RRMainForm rrMainForm)
        {
            InitializeComponent();
            currentRRMainForm = rrMainForm;
        }

        //Botón añadir
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Añade a la base de datos el RR creado
                //Primero se crea un objeto de la clase RedRabbit con los datos introducidos
                //Creación del objeto
                RedRabbit redRabbit = new RedRabbit();

                //Asignación de parámetros
                if (NumTextBox != null && Int32.Parse(NumTextBox.Text) >= 0 && Int32.Parse(NumTextBox.Text) <= 99) //Se comprueba que el número de RR no está vacío y se encuentra en el rango 00-00
                {
                    //Arreglo del prefijo para que no haya espacios y tenga la estructura correcta RR-##
                    redRabbit.rrNumber = "RR-" + NumTextBox.Text; //Se añade le prefijo RR-
                    redRabbit.rrNumber = MainFunctions.RRNumberFix(redRabbit.rrNumber);

                    redRabbit.rrNumberIng = NumberIngTextBox.Text;
                    redRabbit.rrDescription = DescriptionTextBox.Text;
                    redRabbit.rrProject = ProjectTextBox.Text;
                    redRabbit.rrTech = TechTextBox.Text;
                    redRabbit.rrReference = RefTextBox.Text;
                    redRabbit.rrDate = DatePicker.Text;
                    redRabbit.rrCreatedBy = CreatedByTextBox.Text;
                    redRabbit.rrComments = CommentsTextBox.Text;
                    redRabbit.rrMachine = MachineTextBox.Text;
                    redRabbit.rrMonth = MonthComboBox.Text;

                    //Se crea una instancia de RedRabbitCRUD 
                    // *(1)
                    RedRabbitCRUD redRabbitCRUD = new RedRabbitCRUD();

                    try
                    {
                        //Se ejecuta el procedimiento de modificación
                        redRabbitCRUD.CreateRR(redRabbit);

                        //Verificación
                        MessageBox.Show("RedRabbit añadido correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Cerrar formulario actual
                        this.Close();

                        //Cerrar formulari RRMainForm
                        currentRRMainForm.Close();

                        ////Nueva instancia al formulario
                        RRMainForm newRRMainForm = new RRMainForm();
                        newRRMainForm.Show();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error durante la ejecución en RRAddForms: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //*(1) Esto se hace porque sino estariamos intentando llamar a un método de instancia (UpdateRR) de la clase RedRabbitCRUD como si fuera un método estático. En C# los metodos de instancia requieren que crees una instancia de la clase antes de poder llamarlos.
                }
                else
                {
                    MessageBox.Show("Introduzca un número de RedRabbit entre 00 y 99", "Introduzca un número válido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el RedRabbit. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Botón Cancelar
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
