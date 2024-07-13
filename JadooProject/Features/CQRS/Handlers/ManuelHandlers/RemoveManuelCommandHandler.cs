using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Commands.ManuelCommands;

namespace JadooProject.Features.CQRS.Handlers.ManuelHandlers
{
    public class RemoveManuelCommandHandler
    {
        private readonly IRepository<Manuel> _repository;

        public RemoveManuelCommandHandler(IRepository<Manuel> repository)
        {
            _repository = repository;
        }

        public void Handle(RemoveManuelCommand command)
        {
            _repository.Delete(command.Id);
        }
    }
}
