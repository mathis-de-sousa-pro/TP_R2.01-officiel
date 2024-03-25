namespace TP._11;

/// <summary>
/// Represents detailed information about a file.
/// </summary>
public class FileInfoDetails
{
    #region Fields

    private string _fileName;
    private string _fileNameWithoutExtension;
    private string _extension;
    private string _directoryName;
    private string _rootDirectory;
    private string _parentDirectory;
    private DateTime _creationTime;
    private DateTime _lastWriteTime;
    private DateTime _lastAccessTime;
    private long _fileSize;

    #endregion

    #region Properties

    public string FileName
    {
        get => _fileName;
        set => _fileName = value;
    }

    public string FileNameWithoutExtension
    {
        get => _fileNameWithoutExtension;
        set => _fileNameWithoutExtension = value;
    }

    public string Extension
    {
        get => _extension;
        set => _extension = value;
    }

    public string DirectoryName
    {
        get => _directoryName;
        set => _directoryName = value;
    }

    public string RootDirectory
    {
        get => _rootDirectory;
        set => _rootDirectory = value;
    }

    public string ParentDirectory
    {
        get => _parentDirectory;
        set => _parentDirectory = value;
    }

    public DateTime CreationTime
    {
        get => _creationTime;
        set => _creationTime = value;
    }

    public DateTime LastWriteTime
    {
        get => _lastWriteTime;
        set => _lastWriteTime = value;
    }

    public DateTime LastAccessTime
    {
        get => _lastAccessTime;
        set => _lastAccessTime = value;
    }

    public long FileSize
    {
        get => _fileSize;
        set => _fileSize = value;
    }

    #endregion


    /// <summary>
    /// Initializes a new instance of the FileInfoDetails class.
    /// </summary>
    /// <param name="file">The FileInfo object to extract details from.</param>
    public FileInfoDetails(FileInfo file)
    {
        FileName = file.Name;
        FileNameWithoutExtension = file.Name.Substring(0, file.Name.Length - file.Extension.Length);
        Extension = file.Extension;
        DirectoryName = file.DirectoryName;
        RootDirectory = file.Directory.Root.ToString();
        ParentDirectory = file.Directory.Parent.ToString();
        CreationTime = file.CreationTime;
        LastWriteTime = file.LastWriteTime;
        LastAccessTime = file.LastAccessTime;
        FileSize = file.Length;
    }

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString()
    {
        return $"Nom du fichier : {FileName}\n" +
               $"Nom du fichier sans l'extension : {FileNameWithoutExtension}\n" +
               $"Extension du fichier : {Extension}\n" +
               $"Nom du répertoire : {DirectoryName}\n" +
               $"Répertoire racine : {RootDirectory}\n" +
               $"Répertoire parent : {ParentDirectory}\n" +
               $"Date de création : {CreationTime}\n" +
               $"Date de modification : {LastWriteTime}\n" +
               $"Date d'accès : {LastAccessTime}\n" +
               $"Taille du fichier : {FileSize}";
    }

    /// <summary>
    /// Returns a string that represents the current FileInfoDetails object.
    /// </summary>
    /// <returns>A string that represents the current FileInfoDetails object.</returns>
    public string GetFileInfo() => FileName + "      " + FileSize + "       " + CreationTime;


    /// <summary>
    /// Processes a directory and returns a string representation of each file in the directory.
    /// </summary>
    /// <param name="directoryPath">The path of the directory to process.</param>
    /// <returns>A string representation of each file in the directory.</returns>
    public static string ProcessDirectory(string directoryPath)
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
        FileInfo[] files = directoryInfo.GetFiles();
        string result = "";

        foreach (FileInfo file in files)
        {
            FileInfoDetails fileInfoDetails = new FileInfoDetails(file);
            result += fileInfoDetails.GetFileInfo() + "\n";
        }

        return result;
    }

    /// <summary>
    /// Extracts and displays file path information using the FileInfoDetails class.
    /// </summary>
    public static void ExtractFilePathInfoUsingFileInfoDetails()
    {
        Console.Write("Veuillez entrer un chemin de fichier complet : ");
        string filePath = Console.ReadLine();

        // Create a FileInfo object
        FileInfo file = new FileInfo(filePath);

        // Create a FileInfoDetails object using the FileInfo object
        FileInfoDetails fileInfoDetails = new FileInfoDetails(file);

        Console.WriteLine($"Chemin du répertoire : {fileInfoDetails.DirectoryName}");
        Console.WriteLine($"Nom du fichier : {fileInfoDetails.FileName}");
        Console.WriteLine($"Nom du fichier sans extension : {fileInfoDetails.FileNameWithoutExtension}");
        Console.WriteLine($"Extension du fichier : {fileInfoDetails.Extension}");
    }

    /// <summary>
    /// Copies a file to a new file with a different name in the same directory.
    /// </summary>
    public static void CopyFileWithNewName()
    {
        // Ask the user to enter the path of the original file
        Console.Write("Veuillez entrer le chemin du fichier original : ");
        string originalFilePath = Console.ReadLine();

        // Ask the user to enter the new name of the file
        Console.Write("Veuillez entrer le nouveau nom du fichier : ");
        string newFileName = Console.ReadLine();

        // Get the directory of the original file
        string directory = Path.GetDirectoryName(originalFilePath);

        // Combine the directory with the new file name to get the new file path
        string newFilePath = Path.Combine(directory, newFileName);

        // Copy the original file to the new file path
        File.Copy(originalFilePath, newFilePath);

        // Print a message to indicate that the file has been copied
        Console.WriteLine($"Copy {originalFilePath} to {newFilePath} done.");
    }

    /// <summary>
    ///  Copies a file to a new directory.
    ///  </summary>
    public static void CopyFileToNewDirectory()
    {
        // Ask the user to enter the path of the original file
        Console.Write("Veuillez entrer le chemin du fichier original : ");
        string originalFilePath = Console.ReadLine();

        // Ask the user to enter the path of the new directory
        Console.Write("Veuillez entrer le chemin du nouveau répertoire : ");
        string newDirectory = Console.ReadLine();

        // Get the name of the original file
        string fileName = Path.GetFileName(originalFilePath);

        // Combine the new directory with the file name to get the new file path
        string newFilePath = Path.Combine(newDirectory, fileName);

        // Copy the original file to the new file path
        File.Copy(originalFilePath, newFilePath);

        // Print a message to indicate that the file has been copied
        Console.WriteLine($"Copy {originalFilePath} to {newFilePath} done.");
    }
    
    /// <summary>
    ///  Displays the content of a file in hexadecimal.
    /// </summary>
    public static void DisplayFileContentInHexadecimal()
    {
        // Ask the user to enter the path of the file
        Console.Write("Veuillez entrer le chemin du fichier : ");
        string filePath = Console.ReadLine();

        // Open the file
        using (FileStream fileStream = File.OpenRead(filePath))
        {
            // Create a buffer to hold the bytes
            byte[] buffer = new byte[1];

            // Read the file byte by byte
            while (fileStream.Read(buffer, 0, buffer.Length) > 0)
            {
                // Convert the byte to hexadecimal and print it
                Console.Write(buffer[0].ToString("X2") + " ");
            }
        }

        Console.WriteLine();
    }
    
/// <summary>
///  Displays the content of a file.
///  </summary>
    public static void DisplayFileContent()
    {
        // Ask the user to enter the path of the file
        Console.Write("Veuillez entrer le chemin du fichier : ");
        string filePath = Console.ReadLine();

        // Open the file and read its content
        using (StreamReader reader = new StreamReader(filePath))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
        }
    }
}