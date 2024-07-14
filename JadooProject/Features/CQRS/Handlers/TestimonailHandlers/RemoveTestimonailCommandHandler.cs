using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Commands.TestimonialCommands;

namespace JadooProject.Features.CQRS.Handlers.TestimonailHandlers
{
    public class RemoveTestimonailCommandHandler
    {
        private readonly IRepository<Testimonail> _repository;

        public RemoveTestimonailCommandHandler(IRepository<Testimonail> repository)
        {
            _repository = repository;
        }

        public void Handle(RemoveTestimonailCommand command)
        {
            _repository.Delete(command.Id);
        }
    }
}
