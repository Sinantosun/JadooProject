using JadooProject.Features.CQRS.Handlers.DestinationHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Default
{
    public class _DefaultDestinationComponentPartial : ViewComponent
    {
        private readonly GetDestinationForHomeQueryHandler _getDestinationForHomeQueryHandler;

        public _DefaultDestinationComponentPartial(GetDestinationForHomeQueryHandler getDestinationForHomeQueryHandler)
        {
            _getDestinationForHomeQueryHandler = getDestinationForHomeQueryHandler;
        }

        public IViewComponentResult Invoke()
        {
            var value = _getDestinationForHomeQueryHandler.Handle();
            return View(value);
        }
    }
}
