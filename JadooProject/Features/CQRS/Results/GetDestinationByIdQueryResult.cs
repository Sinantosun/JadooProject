namespace JadooProject.Features.CQRS.Results
{
    public class GetDestinationByIdQueryResult
    {
        public int DestinationId { get; set; }
        public string ImageURL { get; set; }
        public string City { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }
    }
}
