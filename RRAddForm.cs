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
        public RRAddForm()
        {
            InitializeComponent();
        }

        //Botón añadir
        private void addButton_Click(object sender, EventArgs e)
        {
            //Añade a la base de datos el RR creado
            //Primero se crea un objeto de la clase RedRabbit con los datos introducidos
            //Creación del objeto
            RedRabbit redRabbit = new RedRabbit();

            //Asignación de parámetros
            if (NumTextBox != null) //Se comprueba que el número de RR no está vacío
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

                //Se ejecuta el procedimiento de modificación
                redRabbitCRUD.CreateRR(redRabbit);


                //*(1) Esto se hace porque sino estariamos intentando llamar a un método de instancia (UpdateRR) de la clase RedRabbitCRUD como si fuera un método estático. En C# los metodos de instancia requieren que crees una instancia de la clase antes de poder llamarlos.
            }

        }
        //Botón Cancelar
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
