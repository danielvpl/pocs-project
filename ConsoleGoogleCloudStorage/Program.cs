using Google.Api.Gax;
using Google.Cloud.Storage.V1;

namespace ConsoleGoogleCloudStorage;

public abstract class Program
{
    private const string BUCKET_NAME = "sidecar-package";
    private const string PROJECT_ID = "avenuecode-mc1";

    private static void Main(string[] args)
    {
        // Set credentials
        //string sharedkeyFilePath = "/Users/daniel.leon.br/Projects/pocs-project/ConsoleGoogleCloudStorage/credentials.json";

        try
        {
            // Connection in Cloud 
            var storageClient = StorageClient.Create();

            // Create a bucket with a globally unique name
            //var bucketName = Guid.NewGuid().ToString();
            //var bucket = client.CreateBucket(projectId, bucketName);

            // Upload a file
            var fileToUpload =
                "/Users/daniel.leon.br/Projects/pocs-project/ConsoleGoogleCloudStorage/files/test.xml";
            using (var fileStream = new FileStream(fileToUpload, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var obj = storageClient.UploadObject(BUCKET_NAME, "test.xml", "application/xml", fileStream);
            }
            
            // Another way to upload files
            //var content = Encoding.UTF8.GetBytes("hello, world");
            //var obj1 = storageClient.UploadObject(bucketName, "file1.txt", "text/plain", new MemoryStream(content));
            
            // List buckets
            var buckets = storageClient.ListBuckets(PROJECT_ID);
            foreach (var obj in buckets)
            {
                Console.WriteLine(obj.Name);
            }

            // List objects in the bucket
            foreach (var obj in storageClient.ListObjects(BUCKET_NAME, ""))
            {
                Console.WriteLine(obj.Name);
            }
            
            // Download a file
            using (var stream = File.OpenWrite("/Users/daniel.leon.br/Projects/pocs-project/ConsoleGoogleCloudStorage/files/test-downloaded.xml"))
            {
                storageClient.DownloadObject(BUCKET_NAME,"test.xml", stream);
                Console.WriteLine("File downloaded successfully!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error! Details: " + ex.Message);
        }
    }
    
    // To use local emulator storage, create and run emulator in port 9023, and use the
    // SetClientEndpoint build method to create the StorageClient object
    //https://github.com/oittaa/gcp-storage-emulator
    private static StorageClient SetClientEndpoint(string endpoint) => new StorageClientBuilder
    {
        EmulatorDetection = EmulatorDetection.EmulatorOnly,
        //BaseUri = endpoint,
        //UnauthenticatedAccess = true, // Change for Production
    }.Build();
}