using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Servico.ViewModels.Produto
{
    public class ProdutoEditarViewModel : ProdutoViewModel
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public int Id { get; set; }
        public IList<ProdutoViewModel> Produtos { get; set; } = new List<ProdutoViewModel>();
    }
}
