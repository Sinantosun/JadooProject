using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Results.DestinationResults;

namespace JadooProject.Features.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationQueryHandler
    {
        private readonly IRepository<Destination> _repository;
        private readonly IMapper _mapper;
        public GetDestinationQueryHandler(IRepository<Destination> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<GetDestinationQueryResult> Handle()
        {
            var values = _repository.GetList();
            var mappedValues = _mapper.Map<List<GetDestinationQueryResult>>(values);
            return mappedValues;
        }

    }
}
