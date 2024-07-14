namespace JadooProject.Features.CQRS.Queries.NewsLetterQueries
{
    public class GetNewsLetterByIdQuery
    {
        public int Id { get; set; }

        public GetNewsLetterByIdQuery(int id)
        {
            Id = id;
        }
    }
}
