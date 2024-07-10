using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Commands;

namespace JadooProject.Features.CQRS.Handlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly IRepository<Destination> _repository;
        private readonly IMapper _mapper;
        public UpdateDestinationCommandHandler(IRepository<Destination> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Handle(UpdateDestinationCommand command)
        {
            var values = _mapper.Map<Destination>(command);
            _repository.Update(values);
        }
    }
}
