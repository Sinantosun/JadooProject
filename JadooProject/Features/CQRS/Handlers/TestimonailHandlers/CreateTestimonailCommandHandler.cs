using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Commands.TestimonialCommands;

namespace JadooProject.Features.CQRS.Handlers.TestimonailHandlers
{
    public class CreateTestimonailCommandHandler
    {
        private readonly IRepository<Testimonail> _repository;
        private readonly IMapper _mapper;

        public CreateTestimonailCommandHandler(IRepository<Testimonail> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Handle(CreateTestimonailCommand command)
        {
            var mappedValues = _mapper.Map<Testimonail>(command);
            _repository.Add(mappedValues);
        }
    }
}
