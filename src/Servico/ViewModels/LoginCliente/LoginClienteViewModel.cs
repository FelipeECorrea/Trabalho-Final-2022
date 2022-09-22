using System.ComponentModel.DataAnnotations;

namespace Servico.ViewModels.LoginCliente
{
    public class LoginClienteViewModel
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
