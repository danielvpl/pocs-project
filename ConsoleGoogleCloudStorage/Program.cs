using Google.Cloud.Storage.V1;

public class Program
{
    static void Main(string[] args)
    {
        /*var client = StorageClient.Create();

        // Create a bucket with a globally unique name
        var bucketName = Guid.NewGuid().ToString();
        var bucket = client.CreateBucket("pocsgcp", bucketName);

        // Upload some files
        var content = Encoding.UTF8.GetBytes("hello, world");
        var obj1 = client.UploadObject(bucketName, "file1.txt", "text/plain", new MemoryStream(content));
        var obj2 = client.UploadObject(bucketName, "folder1/file2.txt", "text/plain", new MemoryStream(content));

        // List objects in the bucket
        foreach (var obj in client.ListObjects(bucketName, ""))
        {
            Console.WriteLine(obj.Name);
        }

        // Download a file
        using (var stream = File.OpenWrite("file1.txt"))
        {
            client.DownloadObject(bucketName, "file1.txt", stream);
        }
        */

        try
        {
            string bucketName = Guid.NewGuid().ToString();
            //string sharedkeyFilePath = "/Users/daniel.leon.br/Projects/pocs-project/ConsoleGoogleCloudStorage/credentials.json";
            
            //var credential = GoogleCredential.FromJson(System.IO.File.ReadAllText(sharedkeyFilePath));
            var storageClient = SetClientEndpoint("http://localhost:8081"); // StorageClient.Create();
            //var storageClient = StorageClient.Create();
            
            // TODO: Create GCP project reference
            var bucket = storageClient.CreateBucket("gcppocs", bucketName, 
                new CreateBucketOptions
                {
                    PredefinedAcl = PredefinedBucketAcl.PublicReadWrite
                });
            
            string filetoUpload = "/Users/daniel.leon.br/Projects/pocs-project/ConsoleGoogleCloudStorage/files/test.xml";
            using (var fileStream = new FileStream(filetoUpload, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                storageClient.UploadObject(bucketName, "test.xml", "text/plain", fileStream);
            }

            Console.WriteLine("File uploaded successfully!");
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    
    private static StorageClient SetClientEndpoint(string endpoint) => new StorageClientBuilder
    {
        BaseUri = endpoint,
        UnauthenticatedAccess = true // Change for Production
    }.Build();
}