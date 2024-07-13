namespace JadooProject.Features.CQRS.Commands.FeatureCommands
{
    public class CreateFeatureCommand
    {

        public string TopDescription { get; set; }
        public string MidDescription { get; set; }
        public string BottomDescription { get; set; }
        public string ImageURL { get; set; }
    }
}
