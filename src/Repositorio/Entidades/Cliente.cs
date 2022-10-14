using Repositorio.Enums;

namespace Repositorio.Entidades
{
    public class Cliente : Usuario
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public IList<Pedido> Pedidos { get; set; }
        public ClienteEmMesa? Status { get; set; }
        public ClienteEmMesa? Autorizacao { get; set; }
      
    }
}
