namespace PathFinder.Services.Data.Interfaces
{
    public interface IGoogleMapsService
    {
        Task<(double Latitude, double Longitude)?> GetCoordinatesAsync(string address);
    }
}
