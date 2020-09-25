using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Consumir.Models.Pessoas
{
    public class CadastrarAmigoViewModel
    {
        [Required(ErrorMessage = "O campo Amigo é obrigatório, favor verificar")]
        [StringLength(250)]
        [DisplayName("Amigo")]
        public int PessoaId { get; set; }
        [Required(ErrorMessage = "O campo Id do amigo é obrigatório, favor verificar")]
        [StringLength(250)]
        [DisplayName("Ids Amigos")]
        public int[] AmigosIds { get; set; }
    }
}
