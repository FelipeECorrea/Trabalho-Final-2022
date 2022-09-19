using Repositorio.Entidades;
using Servico.ViewModels.ProdutoPedido;

namespace Servico.MapeamentoViewModels
{
    public interface IProdutoPedidoViewModelMapeamentoViewModels
    {
        ProdutoPedidoViewModel ConstruirCom(ProdutoPedido produtoPedido);
    }
}
