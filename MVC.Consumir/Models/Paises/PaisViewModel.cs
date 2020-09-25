using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Consumir.Models.Paises
{
    public class PaisViewModel
    {
        public int Id { get; set; }

        public string Foto { get; set; }

        public string Nome { get; set; }
        public List<EstadoViewModel> Estados { get; set; }
    }
}
