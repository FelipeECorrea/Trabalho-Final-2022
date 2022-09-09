namespace Repositorio.Entidades
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public IList<Pedido> Pedidos { get; set; }
        public IList<ProdutoPedido> ProdutosPedidos { get; set; } 

    }
}
