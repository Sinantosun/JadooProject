namespace JadooProject.Features.CQRS.Commands.FeatureCommands
{
    public class RemoveFeatureCommand
    {
        public RemoveFeatureCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
