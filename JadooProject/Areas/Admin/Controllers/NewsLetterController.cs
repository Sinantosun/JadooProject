using AutoMapper;
using JadooProject.Features.CQRS.Commands.NewsLetterCommands;
using JadooProject.Features.CQRS.Handlers.NewsLetterHandlers;
using JadooProject.Features.CQRS.Queries.NewsLetterQueries;
using JadooProject.Features.CQRS.Results.NewsLetterResults;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class NewsLetterController : Controller
    {
        private readonly GetNewsLetterQueryHandler _getNewsLetterQueryHandler;
        private readonly UpdateNewsLetterCommandHandler _updateNewsLetterCommandHandler;
        private readonly RemoveNewsLetterCommandHandler _removeNewsLetterCommandHandler;    
        private readonly GetNewsLetterByIdQueryHandler _getNewsLetterByIdQueryHandler;
        private readonly IMapper _mapper;

        public NewsLetterController(GetNewsLetterQueryHandler getNewsLetterQueryHandler, UpdateNewsLetterCommandHandler updateNewsLetterCommandHandler, RemoveNewsLetterCommandHandler removeNewsLetterCommandHandler, GetNewsLetterByIdQueryHandler getNewsLetterByIdQueryHandler, IMapper mapper)
        {
            _getNewsLetterQueryHandler = getNewsLetterQueryHandler;
            _updateNewsLetterCommandHandler = updateNewsLetterCommandHandler;
            _removeNewsLetterCommandHandler = removeNewsLetterCommandHandler;
            _getNewsLetterByIdQueryHandler = getNewsLetterByIdQueryHandler;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var value = _getNewsLetterQueryHandler.Handle();
            return View(value);
        }
        [HttpGet]
        public IActionResult UpdateNewsLetter(int id)
        {
            var value = _getNewsLetterByIdQueryHandler.Handle(new GetNewsLetterByIdQuery(id));
            var mappedValue = _mapper.Map<UpdateNewsLetterCommand>(value);
            return View(mappedValue);
        }
        
       

        [HttpPost]
        public IActionResult UpdateNewsLetter(UpdateNewsLetterCommand command)
        {
            _updateNewsLetterCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteNewsLetter(int id)
        {
            _removeNewsLetterCommandHandler.Handle(new RemoveNewsLetterCommand(id));
            return RedirectToAction("Index");
        }

    }
}
