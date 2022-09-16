using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.ViewModels.Login_Cliente
{
    public class LoginClienteViewModel
    {
        public class LoginViewModel
        {
            [Display(Name = nameof(Email))]
            [Required(ErrorMessage = "Digite o {0}")]
            [EmailAddress(ErrorMessage = "Digite um {0} válido")]
            public string Email { get; set; }

            [Display(Name = nameof(Senha))]
            [Required(ErrorMessage = "Digite a {0}")]
            public string Senha { get; set; }
        }
    }
}
