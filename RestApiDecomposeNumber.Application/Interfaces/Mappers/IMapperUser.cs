using RestApiDecomposeNumber.Application.Dtos;
using RestApiDecomposeNumber.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiDecomposeNumber.Application.Interfaces.Mappers
{
    public interface IMapperUser
    {
        User MapperDtoToEntity(UserDto userDto);
        IEnumerable<UserDto> MapperListUserDto(IEnumerable<User> users);
        UserDto MapperEntityToDto(User user);
    }
}
