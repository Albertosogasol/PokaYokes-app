//Clase para gestionar las operaciones CRUD (Create, Read, Update, Delete) de la base de datos de RedRabbits. 
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokaYokes_app
{
    public class RedRabbitCRUD
    {

        //Agregar nuevo RR
        public void CreateRR(RedRabbit redRabbit)
        {
            using (OleDbConnection conn = new OleDbConnection(MainFunctions.ConStringBuilder()))
            {
                conn.Open();
                string sqlQuery = "INSERT INTO T10RedRabbits (RR_Number, RR_Number_Ing, RR_Description, RR_Date, RR_Project, RR_Tech, RR_Reference, RR_CreatedBy, RR_Machine, RR_Calibration_Month, RR_Comments, RR_Calibration_Chk) VALUES (@RRNumber, @IngNumber, @Description, @Date, @Project, @Tech, @Reference, @CreatedBy, @Machine, @Month, @Comments, @Chk)";
                using (OleDbCommand cmd = new OleDbCommand(sqlQuery, conn))
                {
                    //Asignación de valores a las variables de la consulta
                    cmd.Parameters.AddWithValue("@RRNumber", redRabbit.rrNumber);
                    cmd.Parameters.AddWithValue("@IngNumber", redRabbit.rrNumberIng);
                    cmd.Parameters.AddWithValue("@Description", redRabbit.rrDescription);
                    cmd.Parameters.AddWithValue("@Date", redRabbit.rrDate);
                    cmd.Parameters.AddWithValue("@Project", redRabbit.rrProject);
                    cmd.Parameters.AddWithValue("@Tech", redRabbit.rrTech);
                    cmd.Parameters.AddWithValue("@Reference", redRabbit.rrReference);
                    cmd.Parameters.AddWithValue("@CreatedBy", redRabbit.rrCreatedBy);
                    cmd.Parameters.AddWithValue("@Machine", redRabbit.rrMachine);
                    cmd.Parameters.AddWithValue("@Month", redRabbit.rrCalibrationMonth);
                    cmd.Parameters.AddWithValue("@Comments", redRabbit.rrComments);
                    cmd.Parameters.AddWithValue("Chk", redRabbit.rrCalibrationChk);

                    //Ejecución del comando
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Eliminar RR REVISAR SI ES NECESARIO COMPROBAR PARA ELIMINACIÓN EN CASCADA!!!!!!!!!!!!!
        public void DeleteRR(int number)
        {
            //Unicamente se necesita el número de RR para eliminar

            //Conexión con la base de datos
            using (OleDbConnection conn = new OleDbConnection(MainFunctions.ConStringBuilder()))
            {
                conn.Open();
                string sqlQuery = "DELETE FROM T10RedRabbits WHERE RRNumber = @Number";
                using (OleDbCommand cmd = new OleDbCommand(sqlQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Number", number);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    
        //Actualiza los datos del RR pasado por parámetro en la BBDD
        public void UpdateRR(RedRabbit redRabbit)
        {
            using (OleDbConnection conn = new OleDbConnection(MainFunctions.ConStringBuilder()))
            {
                conn.Open();
                string sqlQuery = "UPDATE T10RedRabbits SET  RR_Number_Ing = @IngNumber, RR_Description = @Description, RR_Date = @Date, RR_Project = @Project, RR_Tech = @Tech, RR_Reference = @Reference, RR_CreatedBy = @CreatedBy, RR_Machine = @Machine, RR_Calibration_Month = @Month, RR_Comments = @Comments, RR_Calibration_Chk = @Chk WHERE RR_Number = @Number";
                using (OleDbCommand cmd = new OleDbCommand(sqlQuery, conn))
                {
                try
                    {
                        //Asignación de valores a las variables de la consulta
                        cmd.Parameters.AddWithValue("@Number", redRabbit.rrNumber);
                        cmd.Parameters.AddWithValue("@IngNumber", redRabbit.rrNumberIng);
                        cmd.Parameters.AddWithValue("@Description", redRabbit.rrDescription);
                        cmd.Parameters.AddWithValue("@Date", redRabbit.rrDate);
                        cmd.Parameters.AddWithValue("@Project", redRabbit.rrProject);
                        cmd.Parameters.AddWithValue("@Tech", redRabbit.rrTech);
                        cmd.Parameters.AddWithValue("@Reference", redRabbit.rrReference);
                        cmd.Parameters.AddWithValue("@CreatedBy", redRabbit.rrCreatedBy);
                        cmd.Parameters.AddWithValue("@Machine", redRabbit.rrMachine);
                        //cmd.Parameters.AddWithValue("@Month", redRabbit.rrCalibrationMonth);
                        cmd.Parameters.AddWithValue("@Month", "ENERO");
                        cmd.Parameters.AddWithValue("@Comments", redRabbit.rrComments);
                        cmd.Parameters.AddWithValue("Chk", redRabbit.rrCalibrationChk);

                        //Ejecución del comando
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en la ejecución de la modificación. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}
