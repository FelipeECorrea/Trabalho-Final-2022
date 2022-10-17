using Repositorio.Entidades;
using Servico.ViewModels.Pedido;

namespace Servico.MapeamentoViewModels
{
    public interface IPedidoServiceViewModelMapeamentoViewModels
    {
        PedidoCadastrarViewModel ConstruirCom(Pedido pedido);
    }
}
