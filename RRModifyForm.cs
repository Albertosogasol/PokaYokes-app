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
            FillBoxes(RRModify);
        }

        private void FillBoxes(RedRabbit rrSent)
        {
            //Rellena los campos correspondientes con los atributos del objeto pasado por argumento
            RRModNumTextBox.Text = MainFunctions.RRNumberTruncate(rrSent.rrNumber); //Se acorta el número para eliminar la parte "RR-"
            RRModNumberIngTextBox.Text = rrSent.rrNumberIng;
            RRModDescriptionTextBox.Text = rrSent.rrDescription;
            RRModProjectTextBox.Text = rrSent.rrProject;
            RRModTechTextBox.Text = rrSent.rrTech;
            RRModRefTextBox.Text = rrSent.rrTech;
            RRModDatePicker.Text = rrSent.rrDate;
            RRModCreatedByTextBox.Text = rrSent.rrCreatedBy;
            RRModCommentsTextBox.Text = rrSent.rrComments;
            RRModMachineTextBox.Text = rrSent.rrMachine;
            RRModCommentsTextBox.Text = rrSent.rrComments;
            RRModMonthComboBox.Text = rrSent.rrMonth;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            //Modifica con los nuevos valores el registro almacenado en la BBDD
            MessageBox.Show(UserSession.CurrentUser.username);
            MessageBox.Show(UserSession.CurrentUser.userRol);
            //UPDATE QUERY
        }
    }
}
