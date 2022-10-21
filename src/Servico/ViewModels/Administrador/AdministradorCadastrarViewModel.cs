using System.ComponentModel.DataAnnotations;

namespace Servico.ViewModels.Administrador
{
    public class AdministradorCadastrarViewModel : AdministradorViewModel
    {
        [Display(Name = nameof(Senha))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MinLength(6, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        public string? Senha { get; set; }
    }
}
