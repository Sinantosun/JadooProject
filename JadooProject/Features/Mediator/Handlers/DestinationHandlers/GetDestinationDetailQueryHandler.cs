using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.Mediator.Queries.DestinationQueries;
using JadooProject.Features.Mediator.Results.DestinationResults;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.DestinationHandlers
{
    public class GetDestinationDetailQueryHandler : IRequestHandler<GetDestinationDetailQuery, GetDestinationDetailQueryResult>
    {
        private readonly IMapper _mapper;
        private readonly JadooContext _jadooContext;

        public GetDestinationDetailQueryHandler( IMapper mapper, JadooContext jadooContext)
        {

            _mapper = mapper;
            _jadooContext = jadooContext;
        }

        public async Task<GetDestinationDetailQueryResult> Handle(GetDestinationDetailQuery request, CancellationToken cancellationToken)
        {
            var value = await _jadooContext.Destinations.FindAsync(request.Id);
            return  _mapper.Map<GetDestinationDetailQueryResult>(value);
            

      
        }
    }
}
