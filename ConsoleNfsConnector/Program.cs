using System.Net;

IPAddress nfsServerIP = IPAddress.Parse("000.000.000.000"); // Server IP

//var credentials = new NetworkCredential("<<user>>", "<<pass>>");

string nfsRootPath = @"\nfs-storage/";

var clientNfs = new NFSLibrary.NfsClient(NFSLibrary.NfsClient.NfsVersion.V4);

// IP, UserId, GroupId, Timeout
// ISSUE: I cannot use the user credentials, to improve
clientNfs.Connect(nfsServerIP, 267512, 287678, 10000);

var directoryName = clientNfs.GetDirectoryName(nfsRootPath);

var devices = clientNfs.GetExportedDevices();

clientNfs.MountDevice(devices[0]);

var files = clientNfs.GetItemList(directoryName);

foreach (var file in files)
{
    Console.WriteLine("Reading file: " + file);
    Console.WriteLine();

    var localPath = Directory.GetCurrentDirectory() + "\\downloads\\";
    
    if(!Directory.Exists(localPath))
        Directory.CreateDirectory(localPath);
    
    clientNfs.Read($"{directoryName}\\{file}", localPath + file);
    
    var fileBytes = File.ReadAllBytes(localPath + file);
    
    Console.WriteLine("File bytes length: " + fileBytes.Length);
    Console.WriteLine();

    StreamReader sr = new StreamReader(localPath + file);

    // Read the first line of text
    var line = sr.ReadLine();    
    Console.WriteLine("File Content: ");
    Console.WriteLine();
    // Continue reading until the end of the file
    while (line != null)
    {
        // Write the line to the console window
        Console.WriteLine(line);

        // Read the next line
        line = sr.ReadLine();
    }

    // Close the file
    sr.Close();    
}

Console.WriteLine();
Console.WriteLine("Finished.");
Console.ReadKey();
