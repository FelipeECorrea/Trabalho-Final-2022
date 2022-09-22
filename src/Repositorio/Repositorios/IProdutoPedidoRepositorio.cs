using Repositorio.Entidades;

namespace Repositorio.Repositorios
{
    public interface IProdutoPedidoRepositorio
    {
        bool Apagar(int id);
        ProdutoPedido Cadastrar(ProdutoPedido produtoPedido);
        void Editar(ProdutoPedido produtoPedido);
        ProdutoPedido? ObterPorId(int id);
        IList<ProdutoPedido> ObterTodos();
    }
}
