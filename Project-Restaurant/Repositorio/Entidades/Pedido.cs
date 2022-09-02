namespace Repositorio.Entidades
{
    public class Pedido : EntidadeBase
    {
        public int ClienteId { get; set; }
        public int MesaId { get; set; }
        public string Observacao { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        ///
        public Cliente Cliente { get; set; }
        public Mesa Mesa { get; set; }
        public Produto Produto { get; set; }
    }
}
