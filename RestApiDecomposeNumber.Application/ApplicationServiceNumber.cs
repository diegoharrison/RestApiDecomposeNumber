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
    public class ApplicationServiceNumber : IApplicationServiceNumber
    {
        private readonly IServiceNumber serviceNumber;
        private readonly IMapperNumber mapperNumber;

        public void Add(NumberDto numberDto)
        {
            var number = mapperNumber.MapperDtoToEntity(numberDto);
            serviceNumber.Add(number);
        }

        public IEnumerable<NumberDto> GetAll()
        {
            var numbers = serviceNumber.GetAll();
            return mapperNumber.MapperListNumberDto(numbers);
        }

        public NumberDto GetById(int id)
        {
            var number = serviceNumber.GetById(id);
            return mapperNumber.MapperEntityToDto(number);
        }

        public void Remove(NumberDto numberDto)
        {
            var number = mapperNumber.MapperDtoToEntity(numberDto);
            serviceNumber.Remove(number);
        }

        public void Update(NumberDto numberDto)
        {
            var number = mapperNumber.MapperDtoToEntity(numberDto);
            serviceNumber.Update(number);
        }
    }
}
