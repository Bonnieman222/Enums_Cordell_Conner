using System;
using System.IO;

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
    static void Main()
    {
        // Birth info
        int myBirthMonth = (int)Months.Apr;  // Example: April
        int myBirthDay = 15;
        int myBirthYear = 1990;

        string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}.";

        // File paths
        string filePath = "myFile.txt";
        string newFilePath = "newFile.txt";

        // 1. Create a file and write text (overwrites if exists)
        File.WriteAllText(filePath, "This is the first line of my file." + Environment.NewLine);

        Console.WriteLine("Contents of myFile.txt after writing:");
        Console.WriteLine(File.ReadAllText(filePath));

        // 2. Append text to file
        File.AppendAllText(filePath, "This is an appended line." + Environment.NewLine);

        Console.WriteLine("Contents of myFile.txt after appending:");
        Console.WriteLine(File.ReadAllText(filePath));

        // 3. Copy file (replace if exists)
        File.Copy(filePath, newFilePath, true);

        // 4. Append birthday string to new file
        File.AppendAllText(newFilePath, myBirthDate + Environment.NewLine);

        Console.WriteLine("Contents of newFile.txt after appending birth date:");
        Console.WriteLine(File.ReadAllText(newFilePath));
    }
}