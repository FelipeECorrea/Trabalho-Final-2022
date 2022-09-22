namespace Repositorio.Entidades
{
    public class ProdutoPedido : EntidadeBase
    {
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
    }
}
