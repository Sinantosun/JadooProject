using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Queries.TestimonailQueries;
using JadooProject.Features.CQRS.Results.TestimonailResults;

namespace JadooProject.Features.CQRS.Handlers.TestimonailHandlers
{
    public class GetTestimonialByIdQueryHandler
    {
        private readonly IRepository<Testimonail> _repository;
        private readonly IMapper _mapper;
        public GetTestimonialByIdQueryHandler(IRepository<Testimonail> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public GetTestimonailByIdQueryResult Handle(GetTestimonialByIdQuery query)
        {
            var value = _repository.GetById(query.Id);
            return _mapper.Map<GetTestimonailByIdQueryResult>(value);
        }
    }
}
