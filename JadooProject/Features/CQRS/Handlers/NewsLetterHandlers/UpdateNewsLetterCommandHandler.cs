using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Commands.NewsLetterCommands;

namespace JadooProject.Features.CQRS.Handlers.NewsLetterHandlers
{
    public class UpdateNewsLetterCommandHandler
    {
        private readonly IRepository<NewsLetter> _repository;
        private readonly IMapper _mapper;

        public UpdateNewsLetterCommandHandler(IRepository<NewsLetter> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Handle(UpdateNewsLetterCommand command)
        {
            var value = _mapper.Map<NewsLetter>(command);
            _repository.Update(value);  
        }
    }
}
