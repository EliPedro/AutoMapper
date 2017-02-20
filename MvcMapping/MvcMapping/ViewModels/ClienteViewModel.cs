using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMapping.ViewModels
{
    public class ClienteViewModel
    {
        [Required(ErrorMessage = "Preencher campo Nome")]
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preencher campo Data de Nascimento")]
        [Display(Name = "Data de nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DataNascimento { get; set; }

        public bool Ativo { get; set; }

        public int NumeroDaSorte { get; set; }
    }
}