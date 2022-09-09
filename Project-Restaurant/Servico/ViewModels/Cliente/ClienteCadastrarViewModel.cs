using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Servico.ViewModels.Cliente
{
    internal class ClienteCadastrarViewModel : ClienteViewModel
    {
        [Display(Name = nameof(Nome))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MinLength(4, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(50, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Nome { get; set; }

        [Display(Name = nameof(Telefone))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MaxLength(11, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string? Telefone { get; set; }

        [Display(Name = nameof(Cpf))]
        public string? Cpf { get; set; }

    }
}
