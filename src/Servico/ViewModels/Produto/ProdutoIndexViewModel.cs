using System.ComponentModel.DataAnnotations;

namespace Servico.ViewModels.Produto
{
    public class ProdutoIndexViewModel
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
    }
}
