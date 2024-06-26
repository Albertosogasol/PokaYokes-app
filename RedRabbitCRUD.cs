﻿//Clase para gestionar las operaciones CRUD (Create, Read, Update, Delete) de la base de datos de RedRabbits. 
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Net.NetworkInformation;
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
            try
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
                        cmd.Parameters.AddWithValue("@Month", redRabbit.rrMonth);
                        cmd.Parameters.AddWithValue("@Comments", redRabbit.rrComments);
                        cmd.Parameters.AddWithValue("@Chk", redRabbit.rrCalibrationChk);

                        //Ejecución del comando
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                //Excepción si existe un valor de RR duplicado
                if ((ex.Message.Contains("duplicado")) || (ex.Message.Contains("duplicate")))
                {
                    MessageBox.Show("Error. Número de 'RR-' duplicado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //Excepción general
                else
                {
                    MessageBox.Show("Error al intentar crear el RedRabbit. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        //Eliminar RR REVISAR SI ES NECESARIO COMPROBAR PARA ELIMINACIÓN EN CASCADA!!!!!!!!!!!!!
        public void DeleteRR(int idNumber)
        {
            //Unicamente se necesita el número de ID para eliminar

            //Conexión con la base de datos
            using (OleDbConnection conn = new OleDbConnection(MainFunctions.ConStringBuilder()))
            {
                conn.Open();
                string sqlQuery = "DELETE FROM T10RedRabbits WHERE RR_Id = @ID";
                using (OleDbCommand cmd = new OleDbCommand(sqlQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", idNumber);
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
                string sqlQuery = "UPDATE T10RedRabbits SET RR_Number = @Number, RR_Number_Ing = @IngNumber, RR_Description = @Description, RR_Date = @Date, RR_Project = @Project, RR_Tech = @Tech, RR_Reference = @Reference, RR_CreatedBy = @CreatedBy, RR_Machine = @Machine, RR_Calibration_Month = @Month, RR_Comments = @Comments, RR_Calibration_Chk = @Chk WHERE RR_Id = @ID";
                using (OleDbCommand cmd = new OleDbCommand(sqlQuery, conn))
                {
                    try
                    {
                        // Asignación de valores a las variables de la consulta
                        cmd.Parameters.AddWithValue("@Number", redRabbit.rrNumber);
                        cmd.Parameters.AddWithValue("@IngNumber", redRabbit.rrNumberIng);
                        cmd.Parameters.AddWithValue("@Description", redRabbit.rrDescription);
                        cmd.Parameters.AddWithValue("@Date", redRabbit.rrDate);
                        cmd.Parameters.AddWithValue("@Project", redRabbit.rrProject);
                        cmd.Parameters.AddWithValue("@Tech", redRabbit.rrTech);
                        cmd.Parameters.AddWithValue("@Reference", redRabbit.rrReference);
                        cmd.Parameters.AddWithValue("@CreatedBy", redRabbit.rrCreatedBy);
                        cmd.Parameters.AddWithValue("@Machine", redRabbit.rrMachine);
                        cmd.Parameters.AddWithValue("@Month", redRabbit.rrMonth);
                        cmd.Parameters.AddWithValue("@Comments", redRabbit.rrComments);
                        cmd.Parameters.AddWithValue("@Chk", redRabbit.rrCalibrationChk);
                        cmd.Parameters.AddWithValue("@ID", redRabbit.rrId);
                        
                        // Ejecución del comando
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No se encontró ninguna fila con el número de RR especificado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("RedRabbit actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
