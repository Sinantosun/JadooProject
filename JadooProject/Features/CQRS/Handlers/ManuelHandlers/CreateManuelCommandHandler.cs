using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Commands.ManuelCommands;

namespace JadooProject.Features.CQRS.Handlers.ManuelHandlers
{
    public class CreateManuelCommandHandler
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Manuel> _repository;

        public CreateManuelCommandHandler(IMapper mapper, IRepository<Manuel> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Handle(CreateManuelCommand command)
        {
            var values =  _mapper.Map<Manuel>(command);
            _repository.Add(values);
        }
    }
}
