using JadooProject.Features.CQRS.Handlers.ManuelHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Default
{
    public class _DefaultBookingComponentPartial : ViewComponent
    {
        private readonly GetManuelQueryHandler manuelQueryHandler;

        public _DefaultBookingComponentPartial(GetManuelQueryHandler manuelQueryHandler)
        {
            this.manuelQueryHandler = manuelQueryHandler;
        }

        public IViewComponentResult Invoke()
        {
            var value = manuelQueryHandler.Handle();
            return View(value);
        }
    }
}
