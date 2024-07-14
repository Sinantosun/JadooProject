using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.Mediator.Commands.NewsLetterCommands;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.NewsLetterHandlers
{
    public class CreateNewsLetterCommandHandler : IRequestHandler<CreateNewsLetterCommand>
    {

        public async Task Handle(CreateNewsLetterCommand request, CancellationToken cancellationToken)
        {
            var context = new JadooContext();

            await context.NewsLetters.AddAsync(new NewsLetter
            {
                Mail = request.Email
            });
            await context.SaveChangesAsync();

        }
    }
}
