using AutoMapper;

namespace Examlet.Config {
    public class MappingProfile:Profile {
        public MappingProfile() {
            CreateMap<Models.Module, ViewModels.ModuleVM>().ReverseMap();
            CreateMap<Models.Card, ViewModels.CardVM>().ReverseMap();
        }
    }
}
