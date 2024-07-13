namespace JadooProject.Features.CQRS.Queries.ManuelQueries
{
    public class GetManuelByIdQuery
    {
        public GetManuelByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
