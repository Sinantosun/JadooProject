using AutoMapper;
using JadooProject.DataAccess.Context;
using JadooProject.Features.Mediator.Queries.TestimonialQueries;
using JadooProject.Features.Mediator.Results.TestimonailResults;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JadooProject.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonailQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        private readonly JadooContext _context;
        private readonly IMapper _mapper;

        public GetTestimonailQueryHandler(JadooContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Testimonails.ToListAsync();
            var mappedValue = _mapper.Map<List<GetTestimonialQueryResult>>(values);
            return mappedValue;
        }
    }
}
