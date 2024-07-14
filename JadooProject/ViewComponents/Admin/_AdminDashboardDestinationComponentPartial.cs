using JadooProject.Features.CQRS.Handlers.DestinationHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Admin
{
    public class _AdminDashboardDestinationComponentPartial : ViewComponent
    {
        private readonly GetDestinationForDashboardQueryHandler handler;

        public _AdminDashboardDestinationComponentPartial(GetDestinationForDashboardQueryHandler handler)
        {
            this.handler = handler;
        }

        public IViewComponentResult Invoke()
        {
            var value = handler.Handle();
            return View(value);
        }
    }
}
