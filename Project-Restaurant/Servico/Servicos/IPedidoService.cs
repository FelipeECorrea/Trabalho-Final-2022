using Repositorio.Entidades;
using Servico.ViewModels;
using Servico.ViewModels.Pedido;

namespace Servico.Servicos
{
    public interface IPedidoService
    {
        void Cadastrar(PedidoCadastrarViewModel pedidoCadastrarViewModel);
        IList<Pedido> ObterTodos();
        void Apagar(int id);
        Pedido ObterPorId(int id);
        IList<SelectViewModel> ObterTodosPedidos();
    }
}