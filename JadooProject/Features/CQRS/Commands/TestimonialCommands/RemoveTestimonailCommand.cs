namespace JadooProject.Features.CQRS.Commands.TestimonialCommands
{
    public class RemoveTestimonailCommand
    {
        public int Id { get; set; }

        public RemoveTestimonailCommand(int id)
        {
            Id = id;
        }
    }
}
