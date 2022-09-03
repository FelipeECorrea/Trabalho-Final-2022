namespace Repositorio.Entidades
{
    public class ProdutoPedido : EntidadeBase
    {
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public int ClienteId { get; set; }
        public Pedido pedido { get; set; }

        public decimal SomaTotal { get; set; }
    }
}
