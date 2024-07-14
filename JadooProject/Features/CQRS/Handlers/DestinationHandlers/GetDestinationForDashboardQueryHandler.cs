using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Results.DestinationResults;

namespace JadooProject.Features.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationForDashboardQueryHandler
    {
        private readonly IDestinationDal _destinationDal;

        private readonly IMapper _mapper;

        public GetDestinationForDashboardQueryHandler(IMapper mapper, IDestinationDal destinationDal)
        {
          
            _mapper = mapper;
            _destinationDal = destinationDal;
        }

        public List<GetDestinationForDashboardQueryResult> Handle()
        {
            var value = _destinationDal.GetLast6Destination();
            return _mapper.Map<List<GetDestinationForDashboardQueryResult>>(value);

        }
    }
}
