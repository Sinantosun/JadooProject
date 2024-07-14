using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Queries.BrandQueries;
using JadooProject.Features.CQRS.Results.BrandResults;

namespace JadooProject.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Brand> _repository;

        public GetBrandByIdQueryHandler(IMapper mapper, IRepository<Brand> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public GetBrandByIdQueryResult Handle(GetBrandByIdQuery query)
        {
            var value = _repository.GetById(query.Id);
            return _mapper.Map<GetBrandByIdQueryResult>(value);
        }
    }
}
