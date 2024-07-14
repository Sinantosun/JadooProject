using JadooProject.Features.CQRS.Handlers.DashboardHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Admin
{
    public class _AdminDashBoardStatisticCompomentPartial : ViewComponent
    {
        private readonly GetDashboardStatisticQueryHandler _getDashboardStatisticQueryHandler;

        public _AdminDashBoardStatisticCompomentPartial(GetDashboardStatisticQueryHandler getDashboardStatisticQueryHandler)
        {
            _getDashboardStatisticQueryHandler = getDashboardStatisticQueryHandler;
        }

        public IViewComponentResult Invoke()
        {
            var value = _getDashboardStatisticQueryHandler.Handle();
            ViewBag.TestimonialCount = value.TestimonailCount;
            ViewBag.NewsLetterCount = value.NewsLetterCount;
            ViewBag.DestinationCount = value.DestinationCount;
            ViewBag.ServiceCount = value.ServiceCount;
            ViewBag.BrandCount = value.BrandCount;
            ViewBag.FeatureCount = value.FeatureCount;
            return View();  
        }
    }
}
