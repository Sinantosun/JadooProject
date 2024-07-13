using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Commands.FeatureCommands;

namespace JadooProject.Features.CQRS.Handlers.FeatureHandlers
{
    public class CreateFeatureCommandHandler
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Feature> _repository;

        public CreateFeatureCommandHandler(IMapper mapper, IRepository<Feature> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Handle(CreateFeatureCommand command)
        {
            var values = _mapper.Map<Feature>(command);
            _repository.Add(values);
        }
    }
}
