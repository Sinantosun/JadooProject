namespace JadooProject.Features.CQRS.Commands.TestimonialCommands
{
    public class UpdateTestimonialCommand
    {
        public int TestimonailID { get; set; }
        public string ImageURL { get; set; }
        public string Comment { get; set; }
        public string NameSurname { get; set; }
        public string Country { get; set; }

        public IFormFile File { get; set; }
    }
}
