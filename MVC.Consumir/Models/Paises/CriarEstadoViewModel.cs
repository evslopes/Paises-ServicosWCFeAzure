using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Consumir.Models.Paises
{
    public class CriarEstadoViewModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O campo nome é obrigatório, favor verificar")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O envio de Foto é obrigatório, favor verificar")]
        public IFormFile ImgFoto { get; set; }
        public string Foto { get; set; }

        public List<PaisViewModel> Paises { get; set; }

        [Required(ErrorMessage = "O campo país é obrigatório, favor verificar")]
        public int PaisId { get; set; }
    }
}
