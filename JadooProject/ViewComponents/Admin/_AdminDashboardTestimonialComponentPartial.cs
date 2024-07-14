using JadooProject.Features.CQRS.Handlers.TestimonailHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Admin
{
    public class _AdminDashboardTestimonialComponentPartial : ViewComponent
    {
        private readonly GetTestimonailForDashboradQueryHandler getTestimonailForDashboradQueryHandler;

        public _AdminDashboardTestimonialComponentPartial(GetTestimonailForDashboradQueryHandler getTestimonailForDashboradQueryHandler)
        {
            this.getTestimonailForDashboradQueryHandler = getTestimonailForDashboradQueryHandler;
        }

        public IViewComponentResult Invoke()
        {
            var value = getTestimonailForDashboradQueryHandler.Handle();
            return View(value);  
        }
    }
}
