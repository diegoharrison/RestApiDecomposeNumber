using RestApiDecomposeNumber.Application.Dtos;
using System.Collections.Generic;

namespace RestApiDecomposeNumber.Application.Interfaces
{
    public interface IApplicationServiceNumber
    {
        void Add(NumberDto numberDto);
        void Update(NumberDto numberDto);
        void Remove(NumberDto numberDto);
        IEnumerable<NumberDto> GetAll();
        NumberDto GetById(int id);
    }
}
