using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Servico.ViewModels.Produto
{
    public class ProdutoViewModel
    {
        public byte Status { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MinLength(4, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "{0} deve ser preenchida")]
        [Range(0, int.MaxValue, ErrorMessage = "{0} deve conter no mínimo {1}")]
        public decimal? Valor { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public string Categoria { get; set; }

        [Display(Name = "Descricao")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public string Descricao { get; set; }

        public IFormFile? Arquivo { get; set; }

    }
}

