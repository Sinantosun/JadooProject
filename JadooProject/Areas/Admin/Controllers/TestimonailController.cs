using JadooProject.Features.CQRS.Handlers.TestimonailHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class TestimonailController : Controller
    {

        private readonly GetTestimonailQueryHandler _getTestimonailQueryHandler;

        public TestimonailController(GetTestimonailQueryHandler getTestimonailQueryHandler)
        {
            _getTestimonailQueryHandler = getTestimonailQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getTestimonailQueryHandler.Handle();
            return View(values);
        }
    }
}
