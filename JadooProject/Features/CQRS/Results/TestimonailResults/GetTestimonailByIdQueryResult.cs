namespace JadooProject.Features.CQRS.Results.TestimonailResults
{
    public class GetTestimonailByIdQueryResult
    {
        public int TestimonailID { get; set; }
        public string ImageURL { get; set; }
        public string Comment { get; set; }
        public string NameSurname { get; set; }
        public string Country { get; set; }
    }
}
