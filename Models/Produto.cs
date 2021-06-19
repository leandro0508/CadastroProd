using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using System.Web;


namespace CadastroProd.Models
{
    public class Produto 
    {
        
        [Display (Name = "Nº Código")]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "O nome do produto é obrigatório!")]
        public string NomeProd { get; set; }


        [Required(ErrorMessage = "Insira a descrição do produto")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Informe uma descrição de no minímo 10 caracteres a 200")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O peso do produto é obrigatoriamente solicitado!")]
        [Range(1.00, 18.99, ErrorMessage = "Peso inválido")]
        public decimal Peso { get; set; }

        [Required(ErrorMessage = "Informe a categoria do produto")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "O valor da unidade do produto é necessário!")]
        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage = "O valor da unidade do produto está inválido!")]
        public string ValorUnit { get; set; }
    }
}