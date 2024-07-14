using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Results.DestinationResults;

namespace JadooProject.Features.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationForDashboardQueryHandler
    {
        private readonly IRepository<Destination> _repository;
        private readonly IMapper _mapper;

        public GetDestinationForDashboardQueryHandler(IRepository<Destination> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<GetDestinationForDashboardQueryResult> Handle()
        {
            var value = _repository.GetList();
            return _mapper.Map<List<GetDestinationForDashboardQueryResult>>(value);

        }
    }
}
