namespace Repositorio.Entidades
{
    public class Produto : EntidadeBase
    {
        public decimal Valor { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public IList<ProdutoPedido> ProdutosPedidos { get; set; }
        public IList<Pedido> Pedidos { get; set; }
        public string ProdutoCaminho { get; set; }
    }
}
