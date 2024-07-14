namespace JadooProject.Features.CQRS.Queries.TestimonailQueries
{
    public class GetTestimonialByIdQuery
    {
        public GetTestimonialByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
