using System.IO;
using System.Threading.Tasks;
using Amazon;
using Amazon.S3;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace proyecto.Services
{
    public class S3Service
    {
        static readonly RegionEndpoint region = RegionEndpoint.USEast1;
        static IAmazonS3 s3Client;
        private readonly ILogger _logger;
        private readonly string awsKey;
        private readonly string awsSecret;

        public S3Service(ILogger<S3Service> logger, IConfiguration config)
        {
            this._logger = logger;
            this.awsKey = config.GetSection("AwsCredentials").GetValue<string>("AwsKey");
            this.awsSecret = config.GetSection("AwsCredentials").GetValue<string>("AwsSecret");
        }

        public async Task uploadAsync(Stream FileStream, string bucketName, string keyName)
        {
            s3Client = new AmazonS3Client(this.awsKey, this.awsSecret, region);
            // var fileTransferUtility = new TransferUtility(s3Client);
            // await fileTransferUtility.UploadAsync(FileStream, bucketName, keyName);
            return;
        }
    }
}