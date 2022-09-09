namespace Repositorio.Entidades
{
    public class Pedido : EntidadeBase
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int MesaId { get; set; }
        public Mesa Mesa { get; set; }
        public string Observacao { get; set; }
        
        public IList<ProdutoPedido> ProdutosPedidos { get; set; }
    }
}
