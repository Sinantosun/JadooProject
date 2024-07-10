using AutoMapper;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Commands;
using JadooProject.Features.CQRS.Results;

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
        }
    }
}
