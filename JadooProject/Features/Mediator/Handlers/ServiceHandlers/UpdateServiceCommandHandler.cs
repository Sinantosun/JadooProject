using AutoMapper;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.Mediator.Commands.ServiceCommands;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.ServiceHandlers
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand>
    {
        private readonly IMapper _mapper;
        private readonly JadooContext _context;

        public UpdateServiceCommandHandler(IMapper mapper, JadooContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var mappedValues = _mapper.Map<Service>(request);
            _context.Services.Update(mappedValues);
            await _context.SaveChangesAsync();
        }
    }
}
