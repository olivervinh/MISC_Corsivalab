using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Web;
namespace API.Helpers
{
    public class UploadCDNHelper
    {
        private readonly string _accountName = "corsivacdncontent";
        private readonly string _accessKey = "b6ANjJuW0M/DVk4/EPyarz2yhFCnnY4wmPremMMQGf5h58VcA6U5LchCazdqBiAuOwKDtInclYorwyo1dKUqog==";
        private readonly string _containerReference = "corsivalab-management";
        public string today;
        public string Randoms;

        public async Task<string> UploadToAzureCDNAsync(Stream fileStream, string fileName, string contentType)
        {
            string containerReference = string.Empty;
            containerReference = _containerReference;

            StorageCredentials credentials = new StorageCredentials(_accountName, _accessKey);
            CloudStorageAccount account = new CloudStorageAccount(credentials, true);
            CloudBlobClient client = account.CreateCloudBlobClient();
            CloudBlobContainer container = client.GetContainerReference(containerReference);
            CloudBlockBlob blob = container.GetBlockBlobReference(fileName);
            blob.Properties.ContentType = contentType;
            await blob.UploadFromStreamAsync(fileStream);
            return blob.StorageUri.PrimaryUri.AbsoluteUri;
        }

        //public async Task<string> UploadPDFAsync(FileUpload uploadedPDF)
        //{
        //    today = DateTime.UtcNow.ToString("MM-dd-yyyy");
        //    string validCharacters = "ABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";

        //    Random random = new Random();
        //    int size = random.Next(6, 6);

        //    char[] randomCharacters = new char[size];
        //    for (int i = 0; i < size; i++)
        //    {
        //        randomCharacters[i] = validCharacters[random.Next(0, validCharacters.Length)];
        //    }
        //    Randoms = new string(randomCharacters);

        //    if (uploadedPDF.HasFile)
        //    {
        //        string extension = uploadedPDF.FileName.Substring(uploadedPDF.FileName.LastIndexOf(".") + 1).ToLower();
        //        if (extension == "pdf")
        //        {
        //            UploadCDNHelper storage = new UploadCDNHelper();
        //            string fileName = today + "-" + uploadedPDF.FileName + "-" + Randoms + "." + extension;
        //            return await storage.UploadToAzureCDNAsync(uploadedPDF.PostedFile.InputStream, fileName, uploadedPDF.PostedFile.ContentType);
        //        }
        //    }
        //    return string.Empty;
        //}

    }
}