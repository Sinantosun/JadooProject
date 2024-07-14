using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Results.NewsLetterResults;

namespace JadooProject.Features.CQRS.Handlers.NewsLetterHandlers
{
    public class GetNewsLetterQueryHandler
    {
        private readonly IRepository<NewsLetter> _repository;
        private readonly IMapper _mapper;
        public GetNewsLetterQueryHandler(IRepository<NewsLetter> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<GetNewsLetterQueryResult> Handle()
        {
            var value = _repository.GetList();
            return _mapper.Map<List<GetNewsLetterQueryResult>>(value);
        }
    }
}
