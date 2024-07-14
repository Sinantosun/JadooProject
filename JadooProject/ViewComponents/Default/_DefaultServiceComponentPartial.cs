using JadooProject.Features.Mediator.Queries.ServiceQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Default
{
    public class _DefaultServiceComponentPartial : ViewComponent
    {
        private readonly IMediator _mediator;

        public _DefaultServiceComponentPartial(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _mediator.Send(new GetServiceQuery());
            return View(values);
        }

    }
}
