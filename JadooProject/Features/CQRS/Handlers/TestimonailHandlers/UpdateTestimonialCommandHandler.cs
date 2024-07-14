using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Commands.TestimonialCommands;

namespace JadooProject.Features.CQRS.Handlers.TestimonailHandlers
{
    public class UpdateTestimonialCommandHandler
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Testimonail> _repository;

        public UpdateTestimonialCommandHandler(IMapper mapper, IRepository<Testimonail> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Handle(UpdateTestimonialCommand command)
        {
            var value = _mapper.Map<Testimonail>(command);
            _repository.Update(value);
        }
    }
}
