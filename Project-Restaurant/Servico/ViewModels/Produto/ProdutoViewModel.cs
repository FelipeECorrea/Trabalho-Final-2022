using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Servico.ViewModels.Produto
{
    public class ProdutoViewModel
    {
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
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "{0} deve conter no mínimo 5 caracteres'")]
        public string Categoria { get; set; }


        [Display(Name = "Descricao")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "{0} deve conter no mínimo 5 caracteres'")]
        public string Descricao { get; set; }
    }
}
