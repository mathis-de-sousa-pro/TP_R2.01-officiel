using System.Diagnostics;
using System.IO.Compression;

namespace TP._11;

/// <summary>
/// Représente des informations détaillées sur un fichier.
/// </summary>
public class FileInfoDetails
{
    private string _nomFichier;
    /// <summary>
    /// Obtient ou définit le nom du fichier.
    /// </summary>
    public string NomFichier => _nomFichier;

    private string _nomFichierSansExtension;
    /// <summary>
    /// Obtient ou définit le nom du fichier sans son extension.
    /// </summary>
    public string NomFichierSansExtension => _nomFichierSansExtension;

    private string _extension;
    /// <summary>
    /// Obtient ou définit l'extension du fichier.
    /// </summary>
    public string Extension => _extension;

    private string _nomRepertoire;
    /// <summary>
    /// Obtient ou définit le nom du répertoire du fichier.
    /// </summary>
    public string NomRepertoire => _nomRepertoire;

    private string _repertoireRacine;
    /// <summary>
    /// Obtient ou définit le répertoire racine du fichier.
    /// </summary>
    public string RepertoireRacine => _repertoireRacine;

    private string _repertoireParent;
    /// <summary>
    /// Obtient ou définit le répertoire parent du fichier.
    /// </summary>
    public string RepertoireParent => _repertoireParent;

    private DateTime _dateCreation;
    /// <summary>
    /// Obtient ou définit la date de création du fichier.
    /// </summary>
    public DateTime DateCreation => _dateCreation;

    private DateTime _derniereDateEcriture;
    /// <summary>
    /// Obtient ou définit la dernière date d'écriture du fichier.
    /// </summary>
    public DateTime DerniereDateEcriture => _derniereDateEcriture;

    private DateTime _derniereDateAcces;
    /// <summary>
    /// Obtient ou définit la dernière date d'accès au fichier.
    /// </summary>
    public DateTime DerniereDateAcces => _derniereDateAcces;
    
    private long _tailleFichier;
    /// <summary>
    /// Obtient ou définit la taille du fichier.
    /// </summary>
    public long TailleFichier => _tailleFichier;

    /// <summary>
    /// Initialise une nouvelle instance de la classe FileInfoDetails.
    /// </summary>
    /// <param name="file">L'objet FileInfo à partir duquel extraire les détails.</param>
    public FileInfoDetails(FileInfo file)
    {
        _nomFichier = file.Name;
        _nomFichierSansExtension = file.Name.Substring(0, file.Name.Length - file.Extension.Length);
        _extension = file.Extension;
        _nomRepertoire = file.DirectoryName;
        _repertoireRacine = file.Directory.Root.ToString();
        _repertoireParent = file.Directory.Parent.ToString();
        _dateCreation = file.CreationTime;
        _derniereDateEcriture = file.LastWriteTime;
        _derniereDateAcces = file.LastAccessTime;
        _tailleFichier = file.Length;
    }

    /// <summary>
    /// Retourne une chaîne qui représente l'objet actuel.
    /// </summary>
    /// <returns>Une chaîne qui représente l'objet actuel.</returns>
    public override string ToString()
    {
        return $"Nom du fichier : {NomFichier}\n" +
               $"Nom du fichier sans l'extension : {NomFichierSansExtension}\n" +
               $"Extension du fichier : {Extension}\n" +
               $"Nom du répertoire : {NomRepertoire}\n" +
               $"Répertoire racine : {RepertoireRacine}\n" +
               $"Répertoire parent : {RepertoireParent}\n" +
               $"Date de création : {DateCreation}\n" +
               $"Date de modification : {DerniereDateEcriture}\n" +
               $"Date d'accès : {DerniereDateAcces}\n" +
               $"Taille du fichier : {TailleFichier}";
    }
    
    /// <summary>
    /// Obtient des informations de base sur le fichier.
    /// </summary>
    /// <returns>
    /// Une chaîne de caractères contenant le répertoire , le nom du fichier et l'extention du fichier. 
    /// </returns>
    public string GetFileInfoRac()
    {
        return "Base Folder :" + NomRepertoire + "\n" +
               "File Name :" + NomFichier + "\n" +
               "Extension :" + Extension;
    }
    
    /// <summary>
    /// Copies the current file to a new file with the same name, but with " (copy)" appended before the extension.
    /// The new file is created in the same directory as the current file. 
    /// </summary>
    public void CopyMyFile()
    {
        // Combine the directory path and the new file name to create the path for the new file
        string newFilePath = Path.Combine(_nomRepertoire, _nomFichierSansExtension  + " (copy)" +  _extension);

        // Combine the directory path and the current file name to create the path for the current file
        string oldFilePath = Path.Combine(_nomRepertoire, _nomFichier);

        // Copy the current file to the new file
        File.Copy(oldFilePath, newFilePath);
    }
    
    /// <summary>
    /// Copies the current file to a new file with the same name in a specified directory.
    /// </summary>
    /// <param name="newPath">The directory where the new file will be created.</param>
    public void CopyMyFileIntoPath(string newPath)
    {
        // Combine the new directory path and the current file name to create the path for the new file
        string newFilePath = Path.Combine(newPath, _nomFichier);

        // Combine the current directory path and the current file name to create the path for the current file
        string oldFilePath = Path.Combine(_nomRepertoire, _nomFichier);

        // Copy the current file to the new file
        File.Copy(oldFilePath, newFilePath);
    }
    
    /// <summary>
    ///  Affiche le contenue du fichier en hexadeciamle.
    /// </summary>
    public static void DisplayFileContentInHexadecimal()
    {
        Console.Write("Give me a file path : ");
        var filePath = Console.ReadLine();
        using (var fileStream = File.OpenRead(filePath))
        {
            var buffer = new byte[1];

            while (fileStream.Read(buffer, 0, buffer.Length) > 0)
                Console.Write(buffer[0].ToString("X2") + " ");
        }
        Console.WriteLine();
    }
    
    /// <summary>
    ///   afficher sur la console le contenu d’un fichier texte dont le chemin est donné.
    /// </summary>
    public static void DisplayFileContent()
    {
        // Prompt the user for a file path
        Console.Write("Give me a file path : ");
        var filePath = Console.ReadLine();
    
        // Assert that the file path is not null
        Debug.Assert(filePath != null, nameof(filePath) + " != null");

        // Open the file at the given path for reading
        using var reader = new StreamReader(filePath);

        // Read the entire content of the file
        var contenu = reader.ReadToEnd();

        // Print the content of the file to the console
        Console.WriteLine(contenu);
    }

    /// <summary>
    /// Writes user input to a file.
    /// </summary>
    public static void WriteUserInputToFile()
    {
        // Prompt the user for a file path
        Console.Write("Give me a file path: ");
        var filePath = Console.ReadLine();

        // Check if the file path is writable
        if (!File.Exists(filePath) || !new FileInfo(filePath).IsReadOnly)
        {
            // Initialize a boolean variable to control the loop
            bool continueWriting = true;

            // Enter a loop that continues until the user enters "fin"
            while (continueWriting)
            {
                // Prompt the user for a text
                Console.Write("Please enter a text (enter 'fin' to stop): ");
                var text = Console.ReadLine();

                // If the text is "fin", set continueWriting to false
                if (text == "fin")
                {
                    continueWriting = false;
                }
                else
                {
                    // Otherwise, append the text as a new line in the file
                    using (var streamWriter = File.AppendText(filePath))
                    {
                        streamWriter.WriteLine(text);
                    }
                }
            }
        }
        else
        {
            // If the file path is not writable, inform the user
            Console.WriteLine("The file path is not writable.");
        }
    }
    
    /// <summary>
    /// Displays the details of a zip file.
    /// </summary>
    public static void DisplayZipFile()
    {
        // Prompt the user for a zip file path
        Console.Write("Give me a zip-file path : ");
        string zipFilePath = Console.ReadLine();

        // Open the zip file for reading
        using (ZipArchive archive = ZipFile.OpenRead(zipFilePath))
        {
            // Iterate over each entry in the zip file
            foreach (ZipArchiveEntry entry in archive.Entries)
            {
                // Print the name, original size, and compressed size of each entry
                Console.Write($"Nom : {entry.FullName} ; ");
                Console.Write($"Taille originale : {entry.Length} bytes ; ");
                Console.WriteLine($"Taille compressée : {entry.CompressedLength} bytes");
            }
            // Print a separator line
            Console.WriteLine("--------------------------------------------------");
        }
    }

    
   /// <summary>
    /// Retourne une chaîne qui représente l'objet FileInfoDetails actuel.
    /// </summary>
    /// <returns>Une chaîne qui représente l'objet FileInfoDetails actuel.</returns>
    public string GetFileInfo()
    {
        return NomFichier + "      "  + TailleFichier +"      "+ DateCreation;
    }

    /// <summary>
    /// Traite un répertoire et retourne une représentation en chaîne de chaque fichier dans le répertoire.
    /// </summary>
    /// <param name="cheminRepertoire">Le chemin du répertoire à traiter.</param>
    /// <returns>Une représentation en chaîne de chaque fichier dans le répertoire.</returns>
    public static string TraiterRepertoire(string cheminRepertoire)
    {
        DirectoryInfo infoRepertoire = new DirectoryInfo(cheminRepertoire);
        FileInfo[] fichiers = infoRepertoire.GetFiles();
        string resultat = "";

        foreach (FileInfo fichier in fichiers)
        {
            FileInfoDetails detailsFichier = new FileInfoDetails(fichier);
            resultat += detailsFichier.GetFileInfo() + "\n";
        }

        return resultat;
    }
}