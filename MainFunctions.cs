//FUNCIONES PRINCIPALES USADAS POR LAS CLASES

//Conexiones con las bases de datos

using System.Data.OleDb;
using System;

public static class MainFunctions
{

    public static string conStringBuilder()
    {
        string dbProvider;
        string dbSource;

        dbProvider = "Provider = Microsoft.ACE.OLEDB.12.0; ";

        //Localización principal
        dbSource = "Data Source = \"\\\\p54itser\\DocCompartida\\Ingenieria\\DocumentacionLineas\\Listado pokayokes.accdb\"";

        string builtString = dbProvider + dbSource;

        return builtString;
    }

} 

