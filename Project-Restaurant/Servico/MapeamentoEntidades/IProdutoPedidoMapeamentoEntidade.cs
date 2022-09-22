using Repositorio.Entidades;
using Servico.ViewModels.ProdutoPedido;

namespace Servico.MapeamentoEntidades
{
    public interface IProdutoPedidoMapeamentoEntidade
    {
        ProdutoPedido ConstruirCom(ProdutoPedidoCadastrarViewModel viewModel);
    }
}
