using JadooProject.Features.Mediator.Results.TestimonailResults;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResult>>
    {
    }
}
