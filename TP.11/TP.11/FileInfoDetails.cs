namespace TP._11;

/// <summary>
/// Represents detailed information about a file.
/// </summary>
public class FileInfoDetails
{
    /// <summary>
    /// Gets or sets the name of the file.
    /// </summary>
    public string FileName { get; set; }

    /// <summary>
    /// Gets or sets the name of the file without its extension.
    /// </summary>
    public string FileNameWithoutExtension { get; set; }

    /// <summary>
    /// Gets or sets the extension of the file.
    /// </summary>
    public string Extension { get; set; }

    /// <summary>
    /// Gets or sets the directory name of the file.
    /// </summary>
    public string DirectoryName { get; set; }

    /// <summary>
    /// Gets or sets the root directory of the file.
    /// </summary>
    public string RootDirectory { get; set; }

    /// <summary>
    /// Gets or sets the parent directory of the file.
    /// </summary>
    public string ParentDirectory { get; set; }

    /// <summary>
    /// Gets or sets the creation time of the file.
    /// </summary>
    public DateTime CreationTime { get; set; }

    /// <summary>
    /// Gets or sets the last write time of the file.
    /// </summary>
    public DateTime LastWriteTime { get; set; }

    /// <summary>
    /// Gets or sets the last access time of the file.
    /// </summary>
    public DateTime LastAccessTime { get; set; }

    /// <summary>
    /// Gets or sets the size of the file.
    /// </summary>
    public long FileSize { get; set; }

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
public string GetFileInfo()
{
    return FileName + "      "  + FileSize +"       "+ CreationTime;
}

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
}