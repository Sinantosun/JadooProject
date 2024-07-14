using AutoMapper;
using JadooProject.Features.CQRS.Commands.BrandCommands;
using JadooProject.Features.CQRS.Handlers.BrandHandlers;
using JadooProject.Features.CQRS.Queries.BrandQueries;
using JadooProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class BrandController : Controller
    {
        private readonly GetBrandQueryHandler _brandQueryHandler;
        private readonly CreateBrandCommandHandler _createBrandCommandHandler;
        private readonly GetBrandByIdQueryHandler _brandByIdQueryHandler;
        private readonly IMapper _mapper;
        private readonly UpdateBrandCommandHandler _updateBrandCommandHandler;
        private readonly RemoveBrandCommandHandler _removeBrandCommandHandler;
        public BrandController(GetBrandQueryHandler brandQueryHandler, CreateBrandCommandHandler createBrandCommandHandler, GetBrandByIdQueryHandler brandByIdQueryHandler, IMapper mapper, UpdateBrandCommandHandler updateBrandCommandHandler, RemoveBrandCommandHandler removeBrandCommandHandler)
        {
            _brandQueryHandler = brandQueryHandler;
            _createBrandCommandHandler = createBrandCommandHandler;
            _brandByIdQueryHandler = brandByIdQueryHandler;
            _mapper = mapper;
            _updateBrandCommandHandler = updateBrandCommandHandler;
            _removeBrandCommandHandler = removeBrandCommandHandler;
        }

        public IActionResult Index()
        {
            var value = _brandQueryHandler.Handle();
            return View(value);
        }
        [HttpGet]
        public IActionResult CreateBrand()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CreateBrand(CreateBrandCommand command)
        {
            string image = ImageViewModel.CreateImage(command.File);
            command.ImageURL = image;
            _createBrandCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateBrand(int id)
        {
            var value = _brandByIdQueryHandler.Handle(new GetBrandByIdQuery(id));
            var mappedValue = _mapper.Map<UpdateBrandCommand>(value);
            return View(mappedValue);
        }
        [HttpPost]
        public IActionResult UpdateBrand(UpdateBrandCommand command)
        {
            if (command.File != null)
            {
                string image = ImageViewModel.CreateImage(command.File);
                command.ImageURL = image;
            }
        
            _updateBrandCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteBrand(int id)
        {
            _removeBrandCommandHandler.Handle(new RemoveBrandCommand(id));
            return RedirectToAction("Index");
        }

    }
}
