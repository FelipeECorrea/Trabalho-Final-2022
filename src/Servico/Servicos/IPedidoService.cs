using Repositorio.Entidades;
using Servico.ViewModels;
using Servico.ViewModels.Pedido;

namespace Servico.Servicos
{
    public interface IPedidoService
    {
        Pedido Cadastrar(PedidoCadastrarViewModel pedidoCadastrarViewModel);
        IList<Pedido> ObterTodos();
        void Apagar(int id);
        Pedido ObterPorId(int id);
        IList<SelectViewModel> ObterTodosPedidos();
        Pedido? ObterPorIdCliente(int clienteId);
        void Atualizar(Pedido pedido);
        List<PedidoItemViewModel> ObterPedidoAtual(int id);
    }
}