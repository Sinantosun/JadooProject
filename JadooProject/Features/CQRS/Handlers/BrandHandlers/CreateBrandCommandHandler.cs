using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Commands.BrandCommands;

namespace JadooProject.Features.CQRS.Handlers.BrandHandlers
{
    public class CreateBrandCommandHandler
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Brand> _repository;

        public CreateBrandCommandHandler(IMapper mapper, IRepository<Brand> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Handle(CreateBrandCommand command)
        {
            var value = _mapper.Map<Brand>(command);    
            _repository.Add(value);
        }
    }
}
