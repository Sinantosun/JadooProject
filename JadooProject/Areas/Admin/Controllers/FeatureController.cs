using AutoMapper;
using JadooProject.Features.CQRS.Commands.FeatureCommands;
using JadooProject.Features.CQRS.Handlers.FeatureHandlers;
using JadooProject.Features.CQRS.Queries.FeatureQueries;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class FeatureController : Controller
    {
        private readonly GetFeatureQueryHandler _getFeatureQueryHandler;
        private readonly GetFeatureByIdQueryHandler _getFeatureByIdQueryHandler;
        private readonly UpdateFeatureCommandHandler _updateFeatureCommandHandler;
        private readonly CreateFeatureCommandHandler _createFeatureCommandHandler;
        private readonly RemoveFeatureCommandHandler _removeFeatureCommandHandler;
        private readonly IMapper _mapper;
        public FeatureController(GetFeatureQueryHandler getFeatureQueryHandler, GetFeatureByIdQueryHandler getFeatureByIdQueryHandler, IMapper mapper, UpdateFeatureCommandHandler updateFeatureCommandHandler, CreateFeatureCommandHandler createFeatureCommandHandler, RemoveFeatureCommandHandler removeFeatureCommandHandler)
        {
            _getFeatureQueryHandler = getFeatureQueryHandler;
            _getFeatureByIdQueryHandler = getFeatureByIdQueryHandler;
            _mapper = mapper;
            _updateFeatureCommandHandler = updateFeatureCommandHandler;
            _createFeatureCommandHandler = createFeatureCommandHandler;
            _removeFeatureCommandHandler = removeFeatureCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getFeatureQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var values = _getFeatureByIdQueryHandler.Handle(new GetFeatureByIdQuery(id));
            var mappedValues = _mapper.Map<UpdateFeatureCommand>(values);
            return View(mappedValues);
        }

        [HttpPost]
        public IActionResult UpdateFeature(UpdateFeatureCommand command)
        {
            _updateFeatureCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteFeature(int id)
        {
            _removeFeatureCommandHandler.Handle(new RemoveFeatureCommand(id));
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult CreateFeature()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureCommand command)
        {
            _createFeatureCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

    }
}
