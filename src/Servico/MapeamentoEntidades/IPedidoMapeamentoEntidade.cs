using Repositorio.Entidades;
using Servico.ViewModels.Pedido;

namespace Servico.MapeamentoEntidades
{
    public interface IPedidoMapeamentoEntidade
    {
        Pedido ConstruirCom(PedidoCadastrarViewModel viewModel);
    }
}