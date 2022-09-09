using Repositorio.Entidades;

namespace Repositorio.Repositorios
{
    public interface IPedidoRepositorio
    {
        Pedido Cadastrar(Pedido pedido);
        Pedido? Apagar(int id);
        Pedido? ObterPorId(int pedidoId);
        void Editar(Pedido pedido);
        IList<Pedido> ObterTodos(); //TODO vERIFICAR COM QUERIA COMO SERA LISTADO OS PEDIDOS
    }
}