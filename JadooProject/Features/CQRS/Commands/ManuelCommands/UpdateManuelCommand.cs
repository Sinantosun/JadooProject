namespace JadooProject.Features.CQRS.Commands.ManuelCommands
{
    public class UpdateManuelCommand
    {
        public int ManuelID { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
