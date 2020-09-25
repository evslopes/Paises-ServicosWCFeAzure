using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Consumir.Models.Pessoas
{
    public class CriarPessoaViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string Foto { get; set; }

        public int EstadoId { get; set; }

        public int PaisId { get; set; }


    }
}
