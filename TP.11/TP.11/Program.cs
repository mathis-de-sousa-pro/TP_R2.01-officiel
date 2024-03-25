namespace TP._11
{
    class Program
    {
        static void Main()
        {
            // Create a FileInfo object for an existing file
            FileInfo file = new FileInfo("C:/Users/malom/Desktop/mm076547/S2/R2_07 - Graphes/TP/4 - Iron Quest.pdf");

            // Create a FileInfoDetails object using the FileInfo object
            FileInfoDetails fileInfoDetails = new FileInfoDetails(file);

            // Print the details of the file
            Console.WriteLine(fileInfoDetails.ToString());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(fileInfoDetails.GetFileInfo());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(FileInfoDetails.TraiterRepertoire("C:/Users/malom/Desktop/mm076547/S2/R2_07 - Graphes/TP/"));
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(fileInfoDetails.GetFileInfoRac());
            Console.WriteLine("--------------------------------------------------");
            FileInfoDetails.DisplayZipFile();            
        }
    }
}