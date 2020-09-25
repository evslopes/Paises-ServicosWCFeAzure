using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Consumir.Models.Paises
{
    public class PaisViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo foto é obrigatório, favor verificar")]
        [StringLength(250)]
        [DisplayName("Foto do País")]
        public string Foto { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório, favor verificar")]
        [StringLength(250)]
        [DisplayName("Nome do País")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo estado é obrigatório, favor verificar")]
        [StringLength(250)]
        [DisplayName("Lista de estados")]
        public List<EstadoViewModel> Estados { get; set; }
    }
}
