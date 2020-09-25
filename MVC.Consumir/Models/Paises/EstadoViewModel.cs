using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Consumir.Models.Paises
{
    public class EstadoViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome do estado é obrigatório, favor verificar")]
        [StringLength(250)]
        [DisplayName("Nome do estado")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo foto do estado é obrigatório, favor verificar")]
        [StringLength(250)]
        [DisplayName("Foto do estado")]
        public string Foto { get; set; }

        public PaisViewModel Pais { get; set; }

        [Required(ErrorMessage = "O campo Id do País é obrigatório, favor verificar")]
        [StringLength(250)]
        [DisplayName("Id do País")]
        public int PaisId { get; set; }
    }
}
