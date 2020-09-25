using MVC.Consumir.Models.Paises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Consumir.Models.Pessoas
{
    public class PessoaViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório, favor verificar")]
        [StringLength(250)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo sobrenome é obrigatório, favor verificar")]
        [StringLength(250)]
        [DisplayName("Sobrenome")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "O campo email é obrigatório, favor verificar")]
        [StringLength(250)]
        [DisplayName("Endereço de Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo telefone é obrigatório, favor verificar")]
        [StringLength(14)]
        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo data de nascimento é obrigatório, favor verificar")]
        [DisplayName("Data de Nascimento")]
        public DateTime DataDeNascimento { get; set; }


        [Required(ErrorMessage = "O campo foto é obrigatório, favor verificar")]
        [DisplayName("Foto do perfil")]
        public string Foto { get; set; }

        [Required(ErrorMessage = "O campo pais é obrigatório, favor verificar")]
        [DisplayName("Pais de origem")]
        public PaisViewModel PaisViewModel { get; set; }

        [Required(ErrorMessage = "O campo estado é obrigatório, favor verificar")]
        [DisplayName("Estado de Origem")]
        public EstadoViewModel EstadoViewModel { get; set; }

        [Required(ErrorMessage = "O campo estado id é obrigatório, favor verificar")]
        [DisplayName("Id do Estado")]
        public int EstadoId { get; set; }

        [Required(ErrorMessage = "O campo pais id é obrigatório, favor verificar")]
        [DisplayName("Id do Pais")]
        public int PaisId { get; set; }


    }
}
