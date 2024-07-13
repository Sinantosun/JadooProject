using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Queries.ManuelQueries;
using JadooProject.Features.CQRS.Results.ManuelResults;

namespace JadooProject.Features.CQRS.Handlers.ManuelHandlers
{
    public class GetManuelByIdQueryHandler
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Manuel> _repository;

        public GetManuelByIdQueryHandler(IMapper mapper, IRepository<Manuel> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

       public GetManuelByIdQueryResult Handle(GetManuelByIdQuery command)
        {
            var value = _repository.GetById(command.Id);
            return _mapper.Map<GetManuelByIdQueryResult>(value);
        }

    }
}
