using JadooProject.Features.Mediator.Queries.TestimonialQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Default
{
    public class _DefaultTestimonialComponentPartial : ViewComponent
    {
        private readonly IMediator _mediator;

        public _DefaultTestimonialComponentPartial(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _mediator.Send(new GetTestimonialQuery());
            return View(value);
        }
    }
}
