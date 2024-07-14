using AutoMapper;
using JadooProject.DataAccess.Context;
using JadooProject.Features.Mediator.Queries.BrandQueries;
using JadooProject.Features.Mediator.Results.BrandsResults;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JadooProject.Features.Mediator.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler : IRequestHandler<GetBrandQuery, List<GetBrandsQueryResult>>
    {
        private readonly IMapper _mapper;
        private readonly JadooContext _context;

        public GetBrandQueryHandler(IMapper mapper, JadooContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<GetBrandsQueryResult>> Handle(GetBrandQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Brands.ToListAsync();
            return _mapper.Map<List<GetBrandsQueryResult>>(values);
        }
    }
}
