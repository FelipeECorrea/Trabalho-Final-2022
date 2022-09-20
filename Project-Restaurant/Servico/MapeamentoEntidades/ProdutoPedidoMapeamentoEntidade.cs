using Repositorio.Entidades;
using Servico.ViewModels.ProdutoPedido;

namespace Servico.MapeamentoEntidades
{
    public class ProdutoPedidoMapeamentoEntidade : IProdutoPedidoMapeamentoEntidade
    {
        public ProdutoPedido ConstruirCom(ProdutoPedidoCadastrarViewModel viewModel) =>
            new ProdutoPedido
            {
                PedidoId = viewModel.PedidoId,
                Valor = viewModel.Valor

            };
    }
}
