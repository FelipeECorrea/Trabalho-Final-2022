namespace Repositorio.Entidades
{
    public class Produto : EntidadeBase
    {
        public decimal Valor { get; set; }
        public string Nome { get; set; }
        public string categoria { get; set; }
        public string descricao { get; set; }
    }
}
