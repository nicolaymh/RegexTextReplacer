
using System.Text.RegularExpressions;




// Relative path to the source file from the bin\Debug or bin\Release directory
string sourceFilePath = @"..\..\..\C#.md";  // This goes up three directories to the project root

// Relative path to the destination file, also in the project root
string destinationFilePath = @"..\..\..\CSharp.md";

try
{
    // Ensure the file exists before attempting to read it
    if (!File.Exists(sourceFilePath))
    {
        Console.WriteLine($"Error: The file '{sourceFilePath}' does not exist.");
        return;
    }

    // Read the content of the original file
    string data = File.ReadAllText(sourceFilePath);

    // Replace all instances of "C#" with "CSharp" ignoring case sensitivity
    string newData = Regex.Replace(data, "C#", "CSharp", RegexOptions.IgnoreCase);

    // Write the modified content to the new file
    File.WriteAllText(destinationFilePath, newData);

    Console.WriteLine("The file has been modified and saved successfully in " + destinationFilePath);
}

catch (IOException ex)
{
    // Handle I/O errors that can occur on reading or writing the file
    Console.WriteLine("Error reading or writing the file.");
    Console.WriteLine(ex.Message);
}

catch (Exception ex)
{
    // Handle any other unexpected exceptions
    Console.WriteLine("An unexpected error has occurred.");
    Console.WriteLine(ex.Message);
}