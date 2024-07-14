using AutoMapper;
using JadooProject.Features.CQRS.Commands.TestimonialCommands;
using JadooProject.Features.CQRS.Handlers.TestimonailHandlers;
using JadooProject.Features.CQRS.Queries.TestimonailQueries;
using JadooProject.Features.CQRS.Results.TestimonailResults;
using JadooProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class TestimonailController : Controller
    {

        private readonly GetTestimonailQueryHandler _getTestimonailQueryHandler;
        private readonly CreateTestimonailCommandHandler _createTestimonailCommandHandler;
        private readonly GetTestimonialByIdQueryHandler _getTestimonialByIdCommandHandler;
        private readonly UpdateTestimonialCommandHandler _updateTestimonialCommandHandler;
        private readonly RemoveTestimonailCommandHandler _removeTestimonailCommandHandler;
        private readonly IMapper _mapper;
        public TestimonailController(GetTestimonailQueryHandler getTestimonailQueryHandler, CreateTestimonailCommandHandler createTestimonailCommandHandler, GetTestimonialByIdQueryHandler getTestimonialByIdCommandHandler, IMapper mapper, UpdateTestimonialCommandHandler updateTestimonialCommandHandler, RemoveTestimonailCommandHandler removeTestimonailCommandHandler)
        {
            _getTestimonailQueryHandler = getTestimonailQueryHandler;
            _createTestimonailCommandHandler = createTestimonailCommandHandler;
            _getTestimonialByIdCommandHandler = getTestimonialByIdCommandHandler;
            _mapper = mapper;
            _updateTestimonialCommandHandler = updateTestimonialCommandHandler;
            _removeTestimonailCommandHandler = removeTestimonailCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getTestimonailQueryHandler.Handle();
            return View(values);
        }


        public IActionResult DeleteTestimonail(int id)
        {
            _removeTestimonailCommandHandler.Handle(new RemoveTestimonailCommand(id));
            return RedirectToAction("Index");
        }





        [HttpGet]
        public IActionResult CreateTestimonail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTestimonail(CreateTestimonailCommand command)
        {
            string image = ImageViewModel.CreateImage(command.File);
            command.ImageURL = image;
            _createTestimonailCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateTestimonail(int id)
        {
            var value = _getTestimonialByIdCommandHandler.Handle(new GetTestimonialByIdQuery(id));
            var mappedValues = _mapper.Map<UpdateTestimonialCommand>(value);
            return View(mappedValues);
        }
        [HttpPost]
        public IActionResult UpdateTestimonail(UpdateTestimonialCommand command)
        {
            if (command.File != null)
            {
                string image = ImageViewModel.CreateImage(command.File);
                command.ImageURL = image;
            }

            _updateTestimonialCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
