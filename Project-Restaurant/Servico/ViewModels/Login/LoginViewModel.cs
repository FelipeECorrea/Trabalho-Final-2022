using System.ComponentModel.DataAnnotations;

namespace Servico.ViewModels.Login
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Digite o Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite a Senha")]
        public string Senha { get; set; }
    }
}
