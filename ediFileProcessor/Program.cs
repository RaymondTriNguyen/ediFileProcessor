using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string inputFolder = @"C:\Users\nguye\source\repos\ediFileProcessor\ediFileProcessor\input";
        string outputFolder = @"C:\Users\nguye\source\repos\ediFileProcessor\ediFileProcessor\output";
        string archiveFolder = @"C:\Users\nguye\source\repos\ediFileProcessor\ediFileProcessor\archive";

        try
        {
            Directory.CreateDirectory(outputFolder);
            Directory.CreateDirectory(archiveFolder);

            string[] files = Directory.GetFiles(inputFolder);

            foreach (string filePath in files)
            {
                string fileName = Path.GetFileName(filePath);
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
                string fileExtension = Path.GetExtension(fileName);

                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");

                // Prepare new file names with timestamp
                string outputFileName = $"{fileNameWithoutExtension}_{timestamp}{fileExtension}";
                string archiveFileName = $"{fileNameWithoutExtension}_{timestamp}{fileExtension}";

                string outputFilePath = Path.Combine(outputFolder, outputFileName);
                string archiveFilePath = Path.Combine(archiveFolder, archiveFileName);

                // Copy to output folder
                File.Copy(filePath, outputFilePath, overwrite: true);

                // Move to archive folder
                File.Move(filePath, archiveFilePath);
            }

            Console.WriteLine("Files copied to output with timestamp and moved to archive with timestamp successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
