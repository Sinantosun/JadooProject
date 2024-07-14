using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.Features.CQRS.Results.DestinationResults;

namespace JadooProject.Features.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationForHomeQueryHandler
    {
        private readonly IDestinationDal _destinationDal;
        private readonly IMapper _mapper;
        public GetDestinationForHomeQueryHandler(IDestinationDal destinationDal, IMapper mapper)
        {
            _destinationDal = destinationDal;
            _mapper = mapper;
        }

        public List<GetDestinationForHomeQueryResult> Handle()
        {
            var value = _destinationDal.GetLast3Destination();
            return _mapper.Map<List<GetDestinationForHomeQueryResult>>(value);
        }
    }
}
