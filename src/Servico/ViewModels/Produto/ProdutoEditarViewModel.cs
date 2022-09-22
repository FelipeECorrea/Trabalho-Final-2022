using System.ComponentModel.DataAnnotations;

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
