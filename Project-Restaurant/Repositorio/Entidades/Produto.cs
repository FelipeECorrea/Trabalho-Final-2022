using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    public class Produto : EntidadeBase
    {

        [DisplayFormat(DataFormatString = "{0:0,0.000000}")]
        public decimal Valor { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public IList<ProdutoPedido> ProdutosPedidos { get; set; }
        public string ProdutoCaminho { get; set; }
    }
}
