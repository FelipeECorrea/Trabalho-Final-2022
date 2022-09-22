using Repositorio.Enums;

namespace Repositorio.Entidades
{
    public class Mesa : EntidadeBase
    {
        public int NumeroMesa { get; set; }
        public StatusMesa Status { get; set; }
        public IList<Pedido> Pedidos { get; set; }
    }
}