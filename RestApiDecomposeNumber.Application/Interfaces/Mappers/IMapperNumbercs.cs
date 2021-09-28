using RestApiDecomposeNumber.Application.Dtos;
using RestApiDecomposeNumber.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiDecomposeNumber.Application.Interfaces.Mappers
{
    public interface IMapperNumber
    {
        Number MapperDtoToEntity(NumberDto numberDto);
        IEnumerable<NumberDto> MapperListNumberDto(IEnumerable<Number> numbers);
        NumberDto MapperEntityToDto(Number number);
    }
}
