using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Queries.NewsLetterQueries;
using JadooProject.Features.CQRS.Results.NewsLetterResults;

namespace JadooProject.Features.CQRS.Handlers.NewsLetterHandlers
{
    public class GetNewsLetterByIdQueryHandler
    {
        private readonly IRepository<NewsLetter> _repository;
        private readonly IMapper _mapper;

        public GetNewsLetterByIdQueryHandler(IRepository<NewsLetter> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public GetNewsLetterByIdQueryResult Handle(GetNewsLetterByIdQuery query)
        {
            var value = _repository.GetById(query.Id);
            return _mapper.Map<GetNewsLetterByIdQueryResult>(value);


        }
    }
}
