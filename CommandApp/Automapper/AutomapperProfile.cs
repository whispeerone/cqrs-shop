using AutoMapper;
using CommandApp.Commands.ChangeInfo;
using CommandApp.Events;

namespace CommandApp.Automapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<ChangeInfoCommand, UserInfoChanged>();
        }
    }
}