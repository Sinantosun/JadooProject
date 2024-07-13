namespace JadooProject.Features.CQRS.Queries.FeatureQueries
{
    public class GetFeatureByIdQuery
    {
        public GetFeatureByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
