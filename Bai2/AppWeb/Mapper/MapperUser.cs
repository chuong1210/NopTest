using AppWeb.DTO;
using AppWeb.Model;
using AppWeb.Request;
using AutoMapper;

namespace AppWeb.Mapper
{
    public class MapperUser:Profile
    {
        public MapperUser()
        {
            CreateMap<CreateUserRequest, User>();

            CreateMap<User, UserDTO>();

            CreateMap<UpdateUserRequest, UserDTO>();

                }

    }
}
