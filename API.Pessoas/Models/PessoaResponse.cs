using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Pessoas.Models
{
    public class PessoaResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string Foto { get; set; }
    }
}
