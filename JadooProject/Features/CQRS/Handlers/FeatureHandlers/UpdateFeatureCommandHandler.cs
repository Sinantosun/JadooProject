using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Commands.FeatureCommands;

namespace JadooProject.Features.CQRS.Handlers.FeatureHandlers
{

    public class UpdateFeatureCommandHandler
    {
        private readonly IRepository<Feature> _repository;
        private readonly IMapper _mapper;

        public UpdateFeatureCommandHandler(IRepository<Feature> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Handle(UpdateFeatureCommand command)
        {
            var values = _mapper.Map<Feature>(command);
            _repository.Update(values);
        }
    }
}
