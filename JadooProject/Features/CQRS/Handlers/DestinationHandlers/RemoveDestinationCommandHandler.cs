﻿using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Commands.DestinationCommands;

namespace JadooProject.Features.CQRS.Handlers.DestinationHandlers
{
    public class RemoveDestinationCommandHandler
    {
        private readonly IRepository<Destination> _repository;

        public RemoveDestinationCommandHandler(IRepository<Destination> repository)
        {
            _repository = repository;
        }

        public void Handle(RemoveDestinationCommand command)
        {
            _repository.Delete(command.Id);
        }
    }
}
