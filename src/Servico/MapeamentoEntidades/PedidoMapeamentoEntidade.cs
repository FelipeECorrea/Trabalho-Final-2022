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
          ProdutosPedidos = new List<ProdutoPedido>(),
          Observacao = "Asdhasudasudhausi"
          
      };
    }
}
