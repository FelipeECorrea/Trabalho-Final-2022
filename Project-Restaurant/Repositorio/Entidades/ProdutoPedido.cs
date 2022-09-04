namespace Repositorio.Entidades
{
    public class ProdutoPedido : EntidadeBase
    {
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public decimal SomaTotal { get; set; }
    }
}
