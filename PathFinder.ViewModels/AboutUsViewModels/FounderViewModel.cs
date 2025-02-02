using static System.Net.Mime.MediaTypeNames;

namespace PathFinder.ViewModels.AboutUsViewModels
{
    public class FounderViewModel
    {
        public required string Name { get; set; }

        public required string InstagramLink { get; set; }

        public required string GitHubLink { get; set; }

        public required string FacebookLink { get; set; }

        public string Avatar {  get; set; }
    }
}
