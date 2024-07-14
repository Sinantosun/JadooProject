using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.Features.CQRS.Results.DestinationResults;

namespace JadooProject.Features.CQRS.Handlers.DestinationHandlers
{
    public class GetLastDestinationQueryHandler
    {
       private readonly IMapper _mapper;
        private readonly IDestinationDal _destinationDal;

        public GetLastDestinationQueryHandler(IMapper mapper, IDestinationDal destinationDal)
        {
            _mapper = mapper;
            _destinationDal = destinationDal;
        }

        public GetLastDestinationQueryResult Handle()
        {
            var value = _destinationDal.GetLastDestination();
            return _mapper.Map<GetLastDestinationQueryResult>(value);   
        }
    }
}
