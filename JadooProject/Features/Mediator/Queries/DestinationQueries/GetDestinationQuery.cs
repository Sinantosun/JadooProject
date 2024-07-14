using JadooProject.Features.Mediator.Results.DestinationResults;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.DestinationQueries
{
    public class GetDestinationQuery : IRequest<List<GetDestinationsQueryResult>>
    {
    }
}
