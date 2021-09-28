using System;

namespace RestApiDecomposeNumber.Domain.Entitys
{
    public class User
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public string IsAtivo { get; set; }
    }
}
