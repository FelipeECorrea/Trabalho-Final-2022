using Repositorio.Entidades;

namespace Repositorio.Repositorios
{
    public interface IPedidoRepositorio
    {
        Pedido Cadastrar(Pedido pedido);
        Pedido? Apagar(int id);
        Pedido? ObterPorId(int id);
        void Editar(Pedido pedido);
        IList<Pedido> ObterTodos();
    }
}