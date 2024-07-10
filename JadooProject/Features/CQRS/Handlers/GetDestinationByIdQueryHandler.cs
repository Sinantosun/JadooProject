using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Queries;
using JadooProject.Features.CQRS.Results;

namespace JadooProject.Features.CQRS.Handlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly IRepository<Destination> _repository;
        private readonly IMapper _mapper;
        public GetDestinationByIdQueryHandler(IRepository<Destination> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var value = _repository.GetById(query.Id);
            var mappedValues = _mapper.Map<GetDestinationByIdQueryResult>(value);
            return mappedValues;

        }
    }
}
