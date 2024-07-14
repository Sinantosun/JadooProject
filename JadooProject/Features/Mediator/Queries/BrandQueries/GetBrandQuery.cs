using JadooProject.Features.Mediator.Results.BrandsResults;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.BrandQueries
{
    public class GetBrandQuery : IRequest<List<GetBrandsQueryResult>>
    {
    }
}
