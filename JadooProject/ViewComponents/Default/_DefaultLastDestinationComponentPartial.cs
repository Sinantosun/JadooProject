using JadooProject.Features.CQRS.Handlers.DestinationHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Default
{
    public class _DefaultLastDestinationComponentPartial : ViewComponent
    {
        private readonly GetLastDestinationQueryHandler _getLastDestinationQueryHandler;

        public _DefaultLastDestinationComponentPartial(GetLastDestinationQueryHandler getLastDestinationQueryHandler)
        {
            _getLastDestinationQueryHandler = getLastDestinationQueryHandler;
        }

        public IViewComponentResult Invoke()
        {
            var value = _getLastDestinationQueryHandler.Handle();
            return View(value);
        }
    }
}
