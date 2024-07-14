namespace JadooProject.Features.CQRS.Commands.FeatureCommands
{
    public class UpdateFeatureCommand
    {
        public int FeatureID { get; set; }
        public string TopDescription { get; set; }
        public string MidDescription { get; set; }
        public string BottomDescription { get; set; }
        public string ImageURL { get; set; }

        public IFormFile File { get; set; }
    }
}
