﻿using AutoMapper;
using JadooProject.DataAccess.Entites;
using JadooProject.Features.CQRS.Commands.DestinationCommands;
using JadooProject.Features.CQRS.Commands.FeatureCommands;
using JadooProject.Features.CQRS.Commands.ManuelCommands;
using JadooProject.Features.CQRS.Commands.TestimonialCommands;
using JadooProject.Features.CQRS.Queries.FeatureQueries;
using JadooProject.Features.CQRS.Results.DestinationResults;
using JadooProject.Features.CQRS.Results.FeatureResults;
using JadooProject.Features.CQRS.Results.ManuelResults;
using JadooProject.Features.CQRS.Results.TestimonailResults;
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

            CreateMap<Feature, GetFeatureQueryResult>().ReverseMap();
            CreateMap<Feature, GetFeatureByIdQueryResult>().ReverseMap();

            CreateMap<Feature, UpdateFeatureCommand>().ReverseMap();
            CreateMap<Feature, CreateFeatureCommand>().ReverseMap();


            CreateMap<GetFeatureByIdQueryResult, UpdateFeatureCommand>().ReverseMap();


            CreateMap<Manuel, GetManuelQueryResult>().ReverseMap();
            CreateMap<Manuel, CreateManuelCommand>().ReverseMap();
            CreateMap<Manuel, GetManuelByIdQueryResult>().ReverseMap();
            CreateMap<Manuel, UpdateManuelCommand>().ReverseMap();
            CreateMap<UpdateManuelCommand, GetManuelByIdQueryResult>().ReverseMap();

            CreateMap<Testimonail, GetTestimonailQueryResult>().ReverseMap();
            CreateMap<Testimonail, CreateTestimonailCommand>().ReverseMap();




        }
    }
}
