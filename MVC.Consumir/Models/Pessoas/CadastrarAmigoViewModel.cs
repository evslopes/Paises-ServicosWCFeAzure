using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Consumir.Models.Pessoas
{
    public class CadastrarAmigoViewModel
    {
        public int PessoaId { get; set; }
        public int[] AmigosIds { get; set; }
    }
}
