using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Commands;

namespace JadooProject.Features.CQRS.Handlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly IRepository<Destination> _repository;
        private readonly IMapper _mapper;

        public CreateDestinationCommandHandler(IRepository<Destination> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Handle(CreateDestinationCommand command)
        {
            var mappedValues = _mapper.Map<Destination>(command);
            _repository.Add(mappedValues);
        }
    }
}
