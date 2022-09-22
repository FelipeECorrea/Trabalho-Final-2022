using Repositorio.Entidades;
using Servico.ViewModels.Pedido;

namespace Servico.MapeamentoViewModels
{
    public interface IPedidoViewModelMapeamentoViewModels
    {
        PedidoCadastrarViewModel ConstruirCom(Pedido pedido);
    }
}
