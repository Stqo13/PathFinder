namespace PathFinder.ViewModels.RoleRequestViewModel
{
    public class RoleRequestInfoViewModel
    {
        public required int Id { get; set; }

        public required string Sender { get; set; } = null!;

        public required string Description { get; set; } = null!;

        public required string Status { get; set; } = null!;
    }
}
