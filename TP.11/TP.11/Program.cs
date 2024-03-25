// See https://aka.ms/new-console-template for more information

<<<<<<< Updated upstream
Console.WriteLine("Hello, World!");
=======
            
            // Create a FileInfoDetails object using the FileInfo object
            FileInfoDetails fileInfoDetails = new FileInfoDetails(file);

            // Print the details of the file
            Console.WriteLine(fileInfoDetails.ToString());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(fileInfoDetails.GetFileInfo());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(FileInfoDetails.ProcessDirectory("C:/projets jetbrains/PycharmProjects/revenant's quest/"));
            Console.WriteLine("--------------------------------------------------");
            FileInfoDetails.ExtractFilePathInfoUsingFileInfoDetails();
            
        }
    }
}
>>>>>>> Stashed changes
