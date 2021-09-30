using System;

namespace RestApiDecomposeNumber.Domain.Entitys
{
    public class User : Base
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
