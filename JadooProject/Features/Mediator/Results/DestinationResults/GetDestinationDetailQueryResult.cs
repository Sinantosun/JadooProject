namespace JadooProject.Features.Mediator.Results.DestinationResults
{
    public class GetDestinationDetailQueryResult
    {
        public int DestinationId { get; set; }
        public string ImageURL { get; set; }
        public string City { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
