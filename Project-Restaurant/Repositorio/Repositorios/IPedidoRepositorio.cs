using Repositorio.Entidades;

namespace Repositorio.Repositorios
{
    public interface IPedidoRepositorio
    {
        Pedido Cadastrar(Pedido pedido);
        Pedido? Apagar(int id);
        void Editar(Pedido pedido);
        Pedido? ObterPodId(int PedidoId);
        IList<Pedido> ObterTodos();
    }
}