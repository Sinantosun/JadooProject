using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Results.TestimonailResults;

namespace JadooProject.Features.CQRS.Handlers.TestimonailHandlers
{
    public class GetTestimonailQueryHandler
    {
        private readonly IRepository<Testimonail> _repository;

        private readonly IMapper _mapper;

        public GetTestimonailQueryHandler(IRepository<Testimonail> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<GetTestimonailQueryResult> Handle()
        {
            var values = _repository.GetList();
            return _mapper.Map<List<GetTestimonailQueryResult>>(values);
        }
    }
}
