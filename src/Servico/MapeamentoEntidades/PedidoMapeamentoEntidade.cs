using Repositorio.Entidades;
using Servico.ViewModels.Pedido;

namespace Servico.MapeamentoEntidades
{
    public class PedidoMapeamentoEntidade : IPedidoMapeamentoEntidade
    {
        public Pedido ConstruirCom(PedidoCadastrarViewModel viewModel) =>
      new Pedido
      {
          ClienteId = viewModel.ClienteId,
          MesaId = viewModel.MesaId,
          Observacao = viewModel.Observacao,
          ProdutosPedidos = new List<ProdutoPedido>
          {
          new ProdutoPedido
          {
              ProdutoId = viewModel.ProdutoId,
              Quantidade = viewModel.Quantidade,
          }
          }
      };
    }
}
