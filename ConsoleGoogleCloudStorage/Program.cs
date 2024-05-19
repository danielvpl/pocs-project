using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        var client = StorageClient.Create();

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


        /*try
        {
            string bucketName = "seu-nome-de-bucket";
            string sharedkeyFilePath = "caminho-para-seu-arquivo-de-credenciais.json";

            var credential = GoogleCredential.FromJson(System.IO.File.ReadAllText(sharedkeyFilePath));
            var storageClient = StorageClient.Create(credential);

            string filetoUpload = "caminho-para-seu-arquivo.txt";
            using (var fileStream = new FileStream(filetoUpload, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                storageClient.UploadObject(bucketName, "demo.txt", "text/plain", fileStream);
            }

            Console.WriteLine("Arquivo enviado com sucesso!");
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }*/
    }
}