using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Consumir.Models.Paises
{
    public class EstadoViewModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Foto { get; set; }

        public PaisViewModel Pais { get; set; }

        public int PaisId { get; set; }
    }
}
