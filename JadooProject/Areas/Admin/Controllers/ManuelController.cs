using AutoMapper;
using JadooProject.Features.CQRS.Commands.ManuelCommands;
using JadooProject.Features.CQRS.Handlers.ManuelHandlers;
using JadooProject.Features.CQRS.Queries.ManuelQueries;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class ManuelController : Controller
    {
        private readonly GetManuelQueryHandler _manuelQueryHandler;
        private readonly CreateManuelCommandHandler _createManuelCommandHandler;
        private readonly GetManuelByIdQueryHandler _manuelByIdQueryHandler;
        private readonly IMapper _mapper;
        private readonly UpdateManuelCommandHandler _updateManuelCommandHandler;
        private readonly RemoveManuelCommandHandler _removeManuelCommandHandler;
        public ManuelController(GetManuelQueryHandler manuelQueryHandler, CreateManuelCommandHandler createManuelCommandHandler, IMapper mapper, GetManuelByIdQueryHandler manuelByIdQueryHandler, UpdateManuelCommandHandler updateManuelCommandHandler, RemoveManuelCommandHandler removeManuelCommandHandler)
        {
            _manuelQueryHandler = manuelQueryHandler;
            _createManuelCommandHandler = createManuelCommandHandler;
            _mapper = mapper;
            _manuelByIdQueryHandler = manuelByIdQueryHandler;
            _updateManuelCommandHandler = updateManuelCommandHandler;
            _removeManuelCommandHandler = removeManuelCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _manuelQueryHandler.Handle();
            return View(values);
        }

        public IActionResult DeleteManuel(int id)
        {
            _removeManuelCommandHandler.Handle(new RemoveManuelCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateManuel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateManuel(CreateManuelCommand command)
        {
            _createManuelCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateManuel(int id)
        {
            var values = _manuelByIdQueryHandler.Handle(new GetManuelByIdQuery(id));
            var mappedValues = _mapper.Map<UpdateManuelCommand>(values);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateManuel(UpdateManuelCommand command)
        {
            _updateManuelCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
