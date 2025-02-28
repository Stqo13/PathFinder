using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Minio;
using Minio.DataModel.Args;
using PathFinder.Services.Data.Interfaces;
using System.Net;

namespace PathFinder.Services.Data.Implementations
{
    public class CVUploaderService(
        IConfiguration configuration) : ICVUploaderService
    {
        public async Task Run(IFormFile file, string fileName)
        {
            var bucketName = "job-cvs";
            var contentType = file.ContentType;

            var minionSecret = configuration["Minio:Secret"];
            var minionKey = configuration["Minio:Key"];
            var minionHost = configuration["Minio:Host"];

            var minio = new MinioClient()
                .WithEndpoint(minionHost)
                .WithCredentials(minionKey, minionSecret)
                .WithSSL()
                .Build();
            try
            {
                var beArgs = new BucketExistsArgs().WithBucket(bucketName);
                bool found = await minio.BucketExistsAsync(beArgs);
                if (!found)
                {
                    var mbArgs = new MakeBucketArgs().WithBucket(bucketName);
                    await minio.MakeBucketAsync(mbArgs).ConfigureAwait(false);
                }
                using (var fileStream = new MemoryStream())
                {
                    file.CopyTo(fileStream);
                    var fileBytes = fileStream.ToArray();
                    var putObjectArgs = new PutObjectArgs()
                                    .WithBucket(bucketName)
                                    .WithObject(fileName)
                                    .WithStreamData(new MemoryStream(fileBytes))
                                    .WithObjectSize(fileStream.Length)
                                .WithContentType(contentType);
                    await minio.PutObjectAsync(putObjectArgs).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
