namespace JadooProject.Features.CQRS.Commands
{
    public class UpdateDestinationCommand
    {
        public int DestinationId { get; set; }
        public string ImageURL { get; set; }
        public string City { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }
    }
}
