using MediatR;

namespace JadooProject.Features.Mediator.Commands.NewsLetterCommands
{
    public class CreateNewsLetterCommand : IRequest
    {
        public string Email { get; set; }
    }
}
