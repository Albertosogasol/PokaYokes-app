﻿//FUNCIONES PRINCIPALES USADAS POR LAS CLASES

//Conexiones con las bases de datos

using System.Data.OleDb;
using System;
using System.Windows.Forms;

public static class MainFunctions
{

    public static string ConStringBuilder()
    {
        //String para establecer la conexión con la base de datos. Comentar/descomentar a necesidad
        string dbProvider;
        string dbSource;

        dbProvider = "Provider = Microsoft.ACE.OLEDB.12.0; ";

        //Localización principal
        dbSource = "Data Source = \"\\\\p54itser\\DocCompartida\\Ingenieria\\DocumentacionLineas\\Listado pokayokes.accdb\"";

        //Localización pruebas
        //dbSource = "Data Source = \"\\\\p54itser\\DocCompartida\\Ingenieria\\DocumentacionLineas\\Listado pokayokes.accdb\"";

        string builtString = dbProvider + dbSource;

        return builtString;
    }

    public static OleDbConnection ConnOleDbBuilder()
    {
        //Constructor de la conexión con la base de datos
        OleDbConnection connOleDbBuilderVar = new OleDbConnection(ConStringBuilder());

        return connOleDbBuilderVar;
    }

    public static bool PokaYokesDbTest()
    {
        // Test con la base de datos para comprobar la conexión
        // Devuelve TRUE si hay error
        bool errorChk = false;
        try
        { 
            ConnOleDbBuilder().Open();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al conectar con la base de datos: " + ex.Message,"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            errorChk = true;
        }
        finally
        {
            ConnOleDbBuilder().Close();
        }
        return errorChk;
    }

} 

