namespace TP._11
{
    class Program
    {
        static void Main()
        {
            // Create a FileInfo object for an existing file
            FileInfo file = new FileInfo("C:/projets jetbrains/PycharmProjects/revenant's quest/dic.py");

            // Create a FileInfoDetails object using the FileInfo object
            FileInfoDetails fileInfoDetails = new FileInfoDetails(file);

            // Print the details of the file
            Console.WriteLine(fileInfoDetails.ToString());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(fileInfoDetails.GetFileInfo());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(FileInfoDetails.ProcessDirectory("C:/projets jetbrains/PycharmProjects/revenant's quest/"));
        }
    }
}