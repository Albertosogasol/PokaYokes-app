//FUNCIONES PRINCIPALES USADAS POR LAS CLASES

//Conexiones con las bases de datos

using System.Data.OleDb;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq.Expressions;

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

    public static string RRNumberTruncate(string rrNumberInput)
    {
        //Acorta el número de RR para dejar unicamente el número correspondiente

        string rrPrefix = "RR-"; //Estandar de las numeraciones de RedRabbit

        if (rrNumberInput.StartsWith(rrPrefix)) //Si el string pasado por parámetro comienza con RR- se aplica el recorte
        {
            string rrNumberOutput = rrNumberInput.Substring(rrPrefix.Length); //Acortar con la longitud del prefijo
            return rrNumberOutput;
        }
        else //Si no contien RR- se devuelve el valor pasado por parámetro
        {
            return rrNumberInput;
        }

    }

    public static string RRNumberFix(string rrNumberInput)
    {
        try
        {
            //Verifica y modifica el número de RedRabbit para que sea con la estructura RR-##
            //1º Eliminar espacios en blanco
            rrNumberInput = rrNumberInput.Replace(" ", "");

            //2º Verificar si el string coincide con el patrón
            string pattern = @"^RR-(\d{1,2})$";
            Regex regex = new Regex(pattern);

            Match match = regex.Match(rrNumberInput);
            if (match.Success)
            {
                // Extraer el número y asegurarse de que esté en el rango 00-99
                int number;
                if (int.TryParse(match.Groups[1].Value, out number) && number >= 0 && number <= 99)
                {
                    // Formatear el número con dos dígitos
                    string formattedNumber = number.ToString("D2");
                    // Devolver la cadena en el formato correcto
                    return $"RR-{formattedNumber}";
                }
            }
            // Devolver null si el formato no es válido
            return null;
        }
        catch (Exception ex)
        { 
            MessageBox.Show("Error al intentar convertir el número de RedRabbit. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }


        //********************************EXPLICACIÓN EXPRESIÓN REGULAR**************************************************
        //1. ^: Ancla el inicio del string.Esto significa que el patrón debe comenzar justo desde el principio del string.
        //2. RR - : Busca el texto literal "RR-".La `R` debe estar seguida por otra `R`, y después debe venir un guion(`-`).
        //3. (\d{ 1,2}): Este es un grupo de captura que busca uno o dos dígitos. Veamos más de cerca:
        //   (): Los paréntesis agrupan parte de la expresión regular y permiten capturar el texto que coincide para usarlo después.
        //   \d: Es un metacaracter que coincide con cualquier dígito(equivalente a `[0 - 9]`).
        //   { 1,2}: Es un cuantificador que indica que debe haber entre 1 y 2 dígitos consecutivos. Entonces `\d{ 1,2}` coincide con un número de 1 o 2 dígitos(por ejemplo, `0`, `5`, `10`, `99`).
        //4. $: Ancla el final del string.Esto significa que el patrón debe terminar justo al final del string.

    }
} 

