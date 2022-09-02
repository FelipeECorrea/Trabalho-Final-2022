namespace Repositorio.Entidades
{
    public class Mesa : EntidadeBase
    {
        public int NumeroMesa { get; set; }

        public List<Cliente> Clientes { get; set; }
    }
}