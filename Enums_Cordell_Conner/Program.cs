using System;
using System.IO;

namespace BirthdayFileApp
{
    // Global enum for Months
    public enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create birth date variables
            int myBirthMonth = (int)Months.Mar; // Example: March
            int myBirthDay = 15;                // Example: Day of birth
            int myBirthYear = 1995;             // Example: Year of birth

            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}.";

            // Step 2: Create a file and add text
            string filePath = "myFile.txt";
            File.WriteAllText(filePath, "This is the first line of text.\n");

            // Step 3: Read and print the file
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine("Initial file content:");
            Console.WriteLine(fileContent);

            // Step 4: Append text and display file
            File.AppendAllText(filePath, "This is the appended line of text.\n");
            string updatedContent = File.ReadAllText(filePath);
            Console.WriteLine("After appending:");
            Console.WriteLine(updatedContent);

            // Step 5: Copy file to newFile.txt (overwrite if exists)
            string newFilePath = "newFile.txt";
            File.Copy(filePath, newFilePath, true);

            // Step 6: Append birthday info to newFile and display
            File.AppendAllText(newFilePath, myBirthDate + "\n");
            string newFileContent = File.ReadAllText(newFilePath);
            Console.WriteLine("Final new file content:");
            Console.WriteLine(newFileContent);
        }
    }
}