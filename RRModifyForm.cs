using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokaYokes_app
{
    public partial class RRModifyForm : Form
    {
        //Variables de clase 
        private RedRabbit RRModify;
        private RRMainForm currentRRMainForm;

        public RRModifyForm(RedRabbit redRabbit, RRMainForm rrMainForm)
        {
            InitializeComponent();
            RRModify = redRabbit;
            FillBoxes(RRModify);
            currentRRMainForm = rrMainForm;
        }

        //Relleno de campos
        private void FillBoxes(RedRabbit rrSent)
        {
            //Rellena los campos correspondientes con los atributos del objeto pasado por argumento
            RRModNumTextBox.Text = MainFunctions.RRNumberTruncate(rrSent.rrNumber); //Se acorta el número para eliminar la parte "RR-"
            RRModNumberIngTextBox.Text = rrSent.rrNumberIng;
            RRModDescriptionTextBox.Text = rrSent.rrDescription;
            RRModProjectTextBox.Text = rrSent.rrProject;
            RRModTechTextBox.Text = rrSent.rrTech;
            RRModRefTextBox.Text = rrSent.rrReference;
            RRModDatePicker.Text = rrSent.rrDate;
            RRModCreatedByTextBox.Text = rrSent.rrCreatedBy;
            RRModCommentsTextBox.Text = rrSent.rrComments;
            RRModMachineTextBox.Text = rrSent.rrMachine;
            RRModMonthComboBox.Text = rrSent.rrMonth;
            RRIdTextBox.Text = rrSent.rrId.ToString();

        }

        //Botón cancelar
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Botón modificar
        private void modifyButton_Click(object sender, EventArgs e)
        {
            //Modifica con los nuevos valores el registro almacenado en la BBDD

            //Nuevo objeto de la clase RedRabbit para enviar a CRUD 
            RedRabbit redRabbit = new RedRabbit();

            //Asignación de parámetros
            if (RRModNumTextBox!=null ) //Se comprueba que el número de RR no ha sido borrado
            {
                //Arreglo del prefijo para que no haya espacios y tenga la estructura correcta RR-##
                redRabbit.rrNumber = "RR-" + RRModNumTextBox.Text; //Se añade le prefijo RR-
                redRabbit.rrNumber = MainFunctions.RRNumberFix(redRabbit.rrNumber);
                //Asignación de datos al objeto redRabbit
                redRabbit.rrNumberIng = RRModNumberIngTextBox.Text;
                redRabbit.rrDescription = RRModDescriptionTextBox.Text;
                redRabbit.rrProject = RRModProjectTextBox.Text;
                redRabbit.rrTech = RRModTechTextBox.Text;
                redRabbit.rrReference = RRModRefTextBox.Text;
                redRabbit.rrDate = RRModDatePicker.Text;
                redRabbit.rrCreatedBy = RRModCreatedByTextBox.Text;
                redRabbit.rrComments = RRModCommentsTextBox.Text;
                redRabbit.rrMachine = RRModMachineTextBox.Text;
                redRabbit.rrMonth = RRModMonthComboBox.Text;
                redRabbit.rrNumberOriginal = RRModify.rrNumberOriginal; //Número de RedRabbit original por si se modifica dicho número
                redRabbit.rrId = RRModify.rrId;

                try
                {
                    //Se crea una instancia de RedRabbitCRUD 
                    // *(1)
                    RedRabbitCRUD redRabbitCRUD = new RedRabbitCRUD();

                    //Se ejecuta el procedimiento de modificación
                    redRabbitCRUD.UpdateRR(redRabbit);

                    //Cerrar formulario
                    this.Close();

                    //Cerrar formulari RRMainForm
                    currentRRMainForm.Close();

                    ////Nueva instancia al formulario
                    RRMainForm newRRMainForm = new RRMainForm();
                    newRRMainForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error durante la ejecución de la modificación en RRModifyForm: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                //*(1) Esto se hace porque sino estariamos intentando llamar a un método de instancia (UpdateRR) de la clase RedRabbitCRUD como si fuera un método estático. En C# los metodos de instancia requieren que crees una instancia de la clase antes de poder llamarlos.

                //*(2) Se hace así para facilitar la carga del formulario nuevamente. Cuando se ejecuta el método .Close() se liberan todos los recursos del objeto cerrado, por ello es necesario volver a crear una nueva instancia.
            }



        }
    }
}
