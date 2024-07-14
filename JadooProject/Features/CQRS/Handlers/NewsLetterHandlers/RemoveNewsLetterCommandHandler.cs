using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Commands.NewsLetterCommands;

namespace JadooProject.Features.CQRS.Handlers.NewsLetterHandlers
{
    public class RemoveNewsLetterCommandHandler
    {
        private readonly IRepository<NewsLetter> _repository;

        public RemoveNewsLetterCommandHandler(IRepository<NewsLetter> repository)
        {
            _repository = repository;
        }

        public void Handle(RemoveNewsLetterCommand command)
        {
            _repository.Delete(command.Id);
        }
    }
}
