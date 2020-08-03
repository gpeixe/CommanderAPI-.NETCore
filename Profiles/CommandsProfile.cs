using AutoMapper;
using Commander.Models;
using Commander.Dtos;

namespace Commander.Profiles {

    public class CommandsProfile : Profile {
        
        public CommandsProfile()
        {
            // Source -> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
            CreateMap<CommandUpdateDto, Command>();

        }

    }
    
}