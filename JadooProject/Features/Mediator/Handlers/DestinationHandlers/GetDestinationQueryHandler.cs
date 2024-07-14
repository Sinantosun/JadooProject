using AutoMapper;
using JadooProject.DataAccess.Context;
using JadooProject.Features.Mediator.Queries.DestinationQueries;
using JadooProject.Features.Mediator.Results.DestinationResults;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JadooProject.Features.Mediator.Handlers.DestinationHandlers
{
    public class GetDestinationQueryHandler : IRequestHandler<GetDestinationQuery, List<GetDestinationsQueryResult>>
    {
        private readonly JadooContext _context;
        private readonly IMapper _mapper;

        public GetDestinationQueryHandler(JadooContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<GetDestinationsQueryResult>> Handle(GetDestinationQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Destinations.ToListAsync();
            return _mapper.Map<List<GetDestinationsQueryResult>>(values);
        }
    }
}
