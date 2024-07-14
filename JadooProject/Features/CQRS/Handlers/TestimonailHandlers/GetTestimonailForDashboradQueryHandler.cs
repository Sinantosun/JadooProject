using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Results.TestimonailResults;

namespace JadooProject.Features.CQRS.Handlers.TestimonailHandlers
{
    public class GetTestimonailForDashboradQueryHandler
    {
        private readonly ITestimonailDal _testimonailDal;
        private readonly IMapper _mapper;

        public GetTestimonailForDashboradQueryHandler(ITestimonailDal testimonailDal, IMapper mapper)
        {
            _testimonailDal = testimonailDal;
            _mapper = mapper;
        }

        public List<GetTestimonailForDashboardQueryResult> Handle()
        {
            var values = _testimonailDal.GetTestimonailsForDashboard();
            return _mapper.Map<List<GetTestimonailForDashboardQueryResult>>(values);
        }
    }
}
