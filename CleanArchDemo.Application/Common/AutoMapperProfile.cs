using AutoMapper;
using CleanArchDemo.Application.DTOs;
using CleanArchDemo.Domain.Entity;
namespace CleanArchDemo.Application.Common
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
