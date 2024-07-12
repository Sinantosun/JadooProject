using AutoMapper;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Commands.DestinationCommands;
using JadooProject.Features.CQRS.Results.DestinationResults;
using JadooProject.Features.Mediator.Commands.ServiceCommands;
using JadooProject.Features.Mediator.Results.ServiceResults;

namespace JadooProject.Mapping
{
    public class AutoMapperConfig :Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Destination, GetDestinationQueryResult>().ReverseMap();
            CreateMap<Destination, GetDestinationByIdQueryResult>().ReverseMap();
            CreateMap<Destination, CreateDestinationCommand>().ReverseMap();

            CreateMap<Destination, UpdateDestinationCommand>().ReverseMap();

            CreateMap<Service, GetServiceQueryResult>().ReverseMap();
            CreateMap<Service, GetServiceByIdQueryResult>().ReverseMap();
            CreateMap<Service, CreateServiceCommand>().ReverseMap();
            CreateMap<Service, UpdateServiceCommand>().ReverseMap();
        }
    }
}
