using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Paises.Models
{
    public class Estado
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O campo nome é obrigatório, favor verificar")]
        public string Nome { get; set; }

        public string Foto { get; set; }

        [Required(ErrorMessage = "O campo país é obrigatório, favor verificar")]
        public int PaisId { get; set; }

        [JsonIgnore]
        public virtual Pais Pais { get; set; }

    }
}
