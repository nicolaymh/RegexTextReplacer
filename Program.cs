
using System.Text.RegularExpressions;




string sourceFilePath = "C#.md";
string destinationFilePath = "CSharp.md";

Console.WriteLine("Directorio actual: " + Directory.GetCurrentDirectory());


try
{
    // Asegura que el archivo existe antes de intentar leerlo
    if (!File.Exists(sourceFilePath))
    {
        Console.WriteLine($"Error: El archivo '{sourceFilePath}' no existe.");
        return;
    }

    string data = File.ReadAllText(sourceFilePath);
    string newData = Regex.Replace(data, "C#", "CSharp", RegexOptions.IgnoreCase);
    File.WriteAllText(destinationFilePath, newData);
    Console.WriteLine("The file has been modified and saved successfully.");
}
catch (IOException ex)
{
    Console.WriteLine("Error reading or writing the file.");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An unexpected error has occurred.");
    Console.WriteLine(ex.Message);
}