using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Consumir.Models.Paises
{
    public class CriarPaisViewModel
    {
        public IFormFile ImgFoto { get; set; }

        [Required(ErrorMessage = "O envio de foto é obrigatório, favor verificar")]
        public string Foto { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório, favor verificar")]
        public string Nome { get; set; }

        public List<EstadoViewModel> Estados { get; set; }
    }
}
