using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Results.FeatureResults;

namespace JadooProject.Features.CQRS.Handlers.FeatureHandlers
{
    public class GetFeatureQueryHandler 
    {
        private readonly IRepository<Feature> _repository;
        private readonly IMapper _mapper;

        public GetFeatureQueryHandler(IRepository<Feature> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<GetFeatureQueryResult> Handle()
        {
            var value = _repository.GetList();
            return _mapper.Map<List<GetFeatureQueryResult>>(value);   
        }

    }
}
