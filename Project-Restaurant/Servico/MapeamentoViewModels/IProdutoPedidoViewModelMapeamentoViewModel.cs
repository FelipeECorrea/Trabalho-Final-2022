using Repositorio.Entidades;
using Servico.ViewModels.ProdutoPedido;

namespace Servico.MapeamentoViewModels
{
    public interface IProdutoPedidoViewModelMapeamentoViewModel
    {
        ProdutoPedidoViewModel ConstruirCom(ProdutoPedido produtoPedido);
    }
}
