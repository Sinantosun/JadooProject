using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Results.BrandResults;

namespace JadooProject.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Brand> _repository;

        public GetBrandQueryHandler(IMapper mapper, IRepository<Brand> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public List<GetBrandQueryResult> Handle()
        {
            var value = _repository.GetList();
            return _mapper.Map<List<GetBrandQueryResult>>(value);
        }
    }
}
