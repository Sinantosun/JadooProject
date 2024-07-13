namespace JadooProject.Features.CQRS.Results.FeatureResults
{
    public class GetFeatureQueryResult
    {
        public int FeatureID { get; set; }
        public string TopDescription { get; set; }
        public string MidDescription { get; set; }
        public string BottomDescription { get; set; }
        public string ImageURL { get; set; }
    }
}
