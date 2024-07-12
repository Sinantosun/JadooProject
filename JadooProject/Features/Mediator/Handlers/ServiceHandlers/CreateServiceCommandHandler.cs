using AutoMapper;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.Mediator.Commands.ServiceCommands;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.ServiceHandlers
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand>
    {
        private readonly JadooContext _context;
        private readonly IMapper _mapper;
        public CreateServiceCommandHandler(JadooContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            var mappedValues = _mapper.Map<Service>(request);
            await _context.Services.AddAsync(mappedValues);
            await _context.SaveChangesAsync();
        }
    }
}
