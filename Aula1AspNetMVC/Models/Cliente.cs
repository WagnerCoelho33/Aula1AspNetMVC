using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula1AspNetMVC.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150, ErrorMessage = "Tamanho máximo excedido")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres requeridos")]
        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "Preencher campo nome")]


        public string Nome { get; set; }
        [MaxLength(150, ErrorMessage = "Tamanho máximo excedido")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres requeridos")]
        [Display(Name = "Sobrenome do Cliente")]
        [Required(ErrorMessage = "Preencher campo sobrenome")]

        public string SobreNome { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [MaxLength(150, ErrorMessage = "Tamanho máximo excedido")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres requeridos")]
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Preencher campo E-mail")]
        [EmailAddress(ErrorMessage = "Isso não é um formato de e-mail valido")]
        public string Email { get; set; }

    }
}