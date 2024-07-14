using JadooProject.Features.Mediator.Results.DestinationResults;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.DestinationQueries
{
    public class GetDestinationDetailQuery : IRequest<GetDestinationDetailQueryResult>

    {
        public int Id { get; set; }

        public GetDestinationDetailQuery(int id)
        {
            Id = id;
        }
    }
}
