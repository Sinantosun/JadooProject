namespace JadooProject.Features.CQRS.Queries
{
    public class GetDestinationByIdQuery
    {
        public GetDestinationByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
