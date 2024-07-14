using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Concrete;
using JadooProject.Features.CQRS.Results.DashboardResults;

namespace JadooProject.Features.CQRS.Handlers.DashboardHandlers
{
    public class GetDashboardStatisticQueryHandler
    {
        private readonly ITestimonailDal _testimonailDal;
        private readonly INewsLetterDal _newsLetterDal; 
        private readonly IDestinationDal _destinationDal;
        private readonly IServiceDal _serviceDal;
        private readonly IBrandDal _brandDal;
        private readonly IFeatureDal _featureDal;
        public GetDashboardStatisticQueryHandler(ITestimonailDal testimonailDal, INewsLetterDal newsLetterDal, IDestinationDal destinationDal, IServiceDal serviceDal, IBrandDal brandDal, IFeatureDal featureDal)
        {
            _testimonailDal = testimonailDal;
            _newsLetterDal = newsLetterDal;
            _destinationDal = destinationDal;
            _serviceDal = serviceDal;
            _brandDal = brandDal;
            _featureDal = featureDal;
        }

        public GetDashboardStatisticQueryResult Handle()
        {
            return new GetDashboardStatisticQueryResult()
            {
                TestimonailCount = _testimonailDal.GetTestimonailCount(),
                NewsLetterCount = _newsLetterDal.GetNewsLetterCount(),
                DestinationCount = _destinationDal.getDestinationCount(),
                ServiceCount = _serviceDal.getServiceCount(),
                BrandCount = _brandDal.GetBrandCount(),
                FeatureCount = _featureDal.GetFeatureCount(),
            };
        }

    }
}
