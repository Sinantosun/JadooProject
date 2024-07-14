using JadooProject.Features.Mediator.Queries.BrandQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Default
{
    public class _DefaultBrandComponentPartial : ViewComponent
    {
        private readonly IMediator _mediator;

        public _DefaultBrandComponentPartial(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _mediator.Send(new GetBrandQuery());
            return View(value);
        }
    }
}
