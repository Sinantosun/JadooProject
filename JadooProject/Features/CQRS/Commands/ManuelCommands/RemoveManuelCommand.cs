namespace JadooProject.Features.CQRS.Commands.ManuelCommands
{
    public class RemoveManuelCommand
    {
        public RemoveManuelCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
