namespace TP._11;

public class Program
{
    public static void Main()
    {
        // 1) Afficher les informations des fichiers d'un répertoire
        Console.WriteLine("1) Afficher les informations des fichiers d'un répertoire");
        Console.Write("Veuillez entrer le chemin du répertoire : ");
        string directoryPath = Console.ReadLine();
        Console.WriteLine(FileInfoDetails.ProcessDirectory(directoryPath));
        Console.WriteLine("------------------------------------------");
        Console.WriteLine();

        // 2) Extraire les informations d'un nom de fichier complet
        Console.WriteLine("2) Extraire les informations d'un nom de fichier complet");
        FileInfoDetails.ExtractFilePathInfoUsingFileInfoDetails();
        Console.WriteLine();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine();

        // 3) Copier un fichier en un autre nom dans le même répertoire
        Console.WriteLine("3) Copier un fichier en un autre nom dans le même répertoire");
        FileInfoDetails.CopyFileWithNewName();
        Console.WriteLine();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine();

        // 4) Copier un fichier dans un autre répertoire en conservant le même nom
        Console.WriteLine("4) Copier un fichier dans un autre répertoire en conservant le même nom");
        FileInfoDetails.CopyFileToNewDirectory();
        Console.WriteLine();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine();

        // 5) Afficher le contenu d'un fichier en code hexadécimal
        Console.WriteLine("5) Afficher le contenu d'un fichier en code hexadécimal");
        FileInfoDetails.DisplayFileContentInHexadecimal();
        Console.WriteLine();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine();

        // 6) Afficher le contenu d'un fichier texte
        Console.WriteLine("6) Afficher le contenu d'un fichier texte");
        FileInfoDetails.DisplayFileContent();
        Console.WriteLine();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine();

        // 7) Ajouter du texte à un fichier jusqu'à ce que l'utilisateur entre "fin"
        Console.WriteLine("7) Ajouter du texte à un fichier jusqu'à ce que l'utilisateur entre \"fin\"");
        // Ask the user to enter the path of the file
        Console.Write("Veuillez entrer le chemin du fichier : ");
        string filePath = Console.ReadLine();

        string input = "";
        while (input != "fin")
        {
            // Ask the user to enter the text
            Console.Write("Veuillez entrer le texte (entrez 'fin' pour arrêter) : ");
            input = Console.ReadLine();

            // If the input is not "fin", append it to the file
            if (input != "fin")
            {
                File.AppendAllText(filePath, input + Environment.NewLine);
            }
        }

        Console.WriteLine();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine();

        // 8) Afficher le contenu d'un fichier .zip
        Console.WriteLine("8) Afficher le contenu d'un fichier .zip");
        FileInfoDetails.DisplayZipFileContent();
        Console.WriteLine();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine();
    }
}