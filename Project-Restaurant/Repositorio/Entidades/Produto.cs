namespace Repositorio.Entidades
{
    public class Produto
    {
        public decimal Valor { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public IList<Produto> Produtos { get; set; }
    }
}
