using Microsoft.AspNetCore.Http;
using Minio;

namespace PathFinder.Services.Data.Interfaces
{
    public interface ICVUploaderService
    {
        Task Run(IFormFile file, string fileName);
    }
}
