namespace JadooProject.Features.CQRS.Commands.NewsLetterCommands
{
    public class RemoveNewsLetterCommand
    {
        public int Id { get; set; }

        public RemoveNewsLetterCommand(int id)
        {
            Id = id;
        }
    }
}
