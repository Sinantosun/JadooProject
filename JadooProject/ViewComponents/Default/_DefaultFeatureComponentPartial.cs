using JadooProject.Features.CQRS.Handlers.FeatureHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Default
{
    public class _DefaultFeatureComponentPartial : ViewComponent
    {
        private readonly GetFeatureQueryHandler _getFeatureQueryHandler;

        public _DefaultFeatureComponentPartial(GetFeatureQueryHandler getFeatureQueryHandler)
        {
            _getFeatureQueryHandler = getFeatureQueryHandler;
        }

        public IViewComponentResult Invoke()
        {
            var value = _getFeatureQueryHandler.Handle();
            return View(value);
        }
    }
}
