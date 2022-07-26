using AutoMapper;
using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.ViewModels.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
