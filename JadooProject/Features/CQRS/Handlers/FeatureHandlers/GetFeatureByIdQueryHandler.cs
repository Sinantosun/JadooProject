using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Queries.FeatureQueries;
using JadooProject.Features.CQRS.Results.DestinationResults;
using JadooProject.Features.CQRS.Results.FeatureResults;

namespace JadooProject.Features.CQRS.Handlers.FeatureHandlers
{
    public class GetFeatureByIdQueryHandler
    {
        private readonly IRepository<Feature> _repository;
        private readonly IMapper _mapper;

        public GetFeatureByIdQueryHandler(IRepository<Feature> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public GetFeatureByIdQueryResult Handle(GetFeatureByIdQuery query)
        {
            var value = _repository.GetById(query.Id);
            var mappedValues = _mapper.Map<GetFeatureByIdQueryResult>(value);
            return mappedValues;

        }
    }
}
