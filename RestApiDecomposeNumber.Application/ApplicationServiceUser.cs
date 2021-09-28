using RestApiDecomposeNumber.Application.Dtos;
using RestApiDecomposeNumber.Application.Interfaces;
using RestApiDecomposeNumber.Application.Interfaces.Mappers;
using RestApiDecomposeNumber.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDecomposeNumber.Application
{
    public class ApplicationServiceUser : IApplicationServiceUser
    {
        private readonly IServiceUser serviceUser;
        private readonly IMapperUser mapperUser;

        public ApplicationServiceUser(IServiceUser serviceUser
                                     ,IMapperUser mapperUser)
        {
            this.serviceUser = serviceUser;
            this.mapperUser = mapperUser;
        }

        public void Add(UserDto userDto)
        {
            var user = mapperUser.MapperDtoToEntity(userDto);
            serviceUser.Add(user);
        }

        public IEnumerable<UserDto> GetAll()
        {
            var users = serviceUser.GetAll();
            return mapperUser.MapperListUserDto(users);
        }

        public UserDto GetById(int id)
        {
            var user = serviceUser.GetById(id);
            return mapperUser.MapperEntityToDto(user);
        }

        public void Remove(UserDto userDto)
        {
            var user = mapperUser.MapperDtoToEntity(userDto);
            serviceUser.Remove(user);
        }

        public void Update(UserDto userDto)
        {
            var user = mapperUser.MapperDtoToEntity(userDto);
            serviceUser.Update(user);
        }
    }
}
