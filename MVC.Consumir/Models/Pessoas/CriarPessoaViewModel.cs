using Microsoft.AspNetCore.Http;
using MVC.Consumir.Models.Paises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Consumir.Models.Pessoas
{
    public class CriarPessoaViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório, favor verificar")]
        [StringLength(250)]
        [DisplayName("Nome")] public String Nome { get; set; }


        [Required(ErrorMessage = "O campo sobrenome é obrigatório, favor verificar")]
        [StringLength(250)]
        [DisplayName("Sobrenome")]
        public String Sobrenome { get; set; }

        [Required(ErrorMessage = "O campo email é obrigatório, favor verificar")]
        [StringLength(250)]
        [DisplayName("Endereço de Email")]
        public String Email { get; set; }

        [Required(ErrorMessage = "O campo telefone é obrigatório, favor verificar")]
        [StringLength(14)]
        [DisplayName("Telefone")]
        public String Telefone { get; set; }


        [Required(ErrorMessage = "O campo data de nascimento é obrigatório, favor verificar")]
        [DisplayName("Data de Nascimento")]
        public DateTime DataDeNascimento { get; set; }

        [Required(ErrorMessage = "O campo foto é obrigatório, favor verificar")]
        [DisplayName("Foto do perfil")]
        public IFormFile ImgFoto { get; set; }

        [Required(ErrorMessage = "O campo foto é obrigatório, favor verificar")]
        [DisplayName("Foto do perfil")]
        public String Foto { get; set; }

        [Required(ErrorMessage = "O campo pais é obrigatório, favor verificar")]
        [DisplayName("Pais de origem")]
        public List<PaisViewModel> Paises { get; set; }

        [Required(ErrorMessage = "O campo estado é obrigatório, favor verificar")]
        [DisplayName("Estado de Origem")]
        public List<EstadoViewModel> Estados { get; set; }


        [Required(ErrorMessage = "O campo estado id é obrigatório, favor verificar")]
        [DisplayName("Id do Estado")]
        public int EstadoId { get; set; }

        [Required(ErrorMessage = "O campo pais id é obrigatório, favor verificar")]
        [DisplayName("Id do Pais")]
        public int PaisId { get; set; }


    }
}
