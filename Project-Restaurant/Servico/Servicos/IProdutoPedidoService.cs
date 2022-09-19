using Repositorio.Entidades;
using Servico.ViewModels;
using Servico.ViewModels.ProdutoPedido;

namespace Servico.Servicos
{
    public interface IProdutoPedidoService
    {
        ProdutoPedido Cadastrar(ProdutoPedidoCadastrarViewModel produtoPedidoCadastrarViewModel);
        IList<ProdutoPedido> ObterTodos();
        void Apagar(int id);
        ProdutoPedido ObterPorId(int id);
        IList<SelectViewModel> ObterTodosProdutosPedidos();
    }
}
