using System.ComponentModel.DataAnnotations;

namespace Servico.ViewModels.Produto
{
    public class ProdutoEditarViewModel : ProdutoViewModel
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public int Id { get; set; } = default!;
        public decimal Valor { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public Enum Status { get; set; }
    }
}
