using AutoMapper;
using JadooProject.DataAccess.Context;
using JadooProject.Features.Mediator.Queries.ServiceQueries;
using JadooProject.Features.Mediator.Results.ServiceResults;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly JadooContext _context;
        private readonly IMapper _mapper;
        public GetServiceByIdQueryHandler(JadooContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Services.FindAsync(request.Id);
            return  _mapper.Map<GetServiceByIdQueryResult>(value);

        }
    }
}
