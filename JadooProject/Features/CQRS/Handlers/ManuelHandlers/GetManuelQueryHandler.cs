using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Results.ManuelResults;

namespace JadooProject.Features.CQRS.Handlers.ManuelHandlers
{
    public class GetManuelQueryHandler
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Manuel> _repository;

        public GetManuelQueryHandler(IMapper mapper, IRepository<Manuel> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public List<GetManuelQueryResult> Handle()
        {
            var values = _repository.GetList();

            return _mapper.Map<List<GetManuelQueryResult>>(values);   
        }
    }
}
