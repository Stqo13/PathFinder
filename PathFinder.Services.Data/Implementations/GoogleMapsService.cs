using Microsoft.Extensions.Configuration;
using PathFinder.Services.Data.Interfaces;
using System.Net.Http;
using System.Text.Json;

namespace PathFinder.Services.Data.Implementations
{
    public class GoogleMapsService(
        HttpClient httpClient,
        IConfiguration configuration
        ) : IGoogleMapsService
    {
        private readonly string apiKey = configuration["GoogleMapsApiKey:ApiKey"] ?? throw new NullReferenceException("Api key not found");

        public async Task<(double Latitude, double Longitude)?> GetCoordinatesAsync(string address)
        {
            var url = $"https://maps.googleapis.com/maps/api/geocode/json?address={Uri.EscapeDataString(address)}&key={apiKey}";
            var response = await httpClient.GetStringAsync(url);

            using var doc = JsonDocument.Parse(response);
            var root = doc.RootElement;
            var status = root.GetProperty("status").GetString();


            if (status == "OK")
            {
                var location = root.GetProperty("results")[0].GetProperty("geometry").GetProperty("location");
                double lat = location.GetProperty("lat").GetDouble();
                double lng = location.GetProperty("lng").GetDouble();
                return (lat, lng);
            }

            return null;
        }
    }
}
