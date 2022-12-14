using System.ComponentModel.DataAnnotations;

namespace Servico.ViewModels.Login
{
    public class LoginViewModel
    {
        [Display(Name = nameof(Email))]
        [Required(ErrorMessage = "Digite o {0}")]
        public string Email { get; set; }

        [Display(Name = nameof(Senha))]
        [Required(ErrorMessage = "Digite a {0}")]
        public string Senha { get; set; }
    }
}
