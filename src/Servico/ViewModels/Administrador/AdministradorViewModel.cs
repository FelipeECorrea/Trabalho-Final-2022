using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Servico.ViewModels.Administrador
{
    public class AdministradorViewModel
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
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MaxLength(11, ErrorMessage = "{0} deve ser preenchido")]
        public string? Cpf { get; set; }

        [Display(Name = nameof(Email))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public string? Email { get; set; }


        public IFormFile? Arquivo { get; set; }
    }
}
