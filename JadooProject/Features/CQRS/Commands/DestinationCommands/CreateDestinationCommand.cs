namespace JadooProject.Features.CQRS.Commands.DestinationCommands
{
    public class CreateDestinationCommand
    {
        public string ImageURL { get; set; }
        public string City { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }
    }
}
