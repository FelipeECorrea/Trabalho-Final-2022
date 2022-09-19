using Repositorio.Entidades;
using Servico.ViewModels.ProdutoPedido;

namespace Servico.MapeamentoViewModels
{
    internal class ProdutoPedidoViewModelMapeamentoViewModels : IProdutoPedidoViewModelMapeamentoViewModels
    {
        public ProdutoPedidoViewModel ConstruirCom(ProdutoPedido produtoPedido) =>
            new ProdutoPedidoCadastrarViewModel
            {
                 PedidoId = produtoPedido.PedidoId,
                 ProdutoId = produtoPedido.ProdutoId,
                 Quantidade = produtoPedido.Quantidade,
                 Valor = produtoPedido.Valor
            };
    }
}
