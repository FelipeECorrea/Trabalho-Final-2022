using Repositorio.Entidades;
using Servico.ViewModels.Pedido;
using Servico.ViewModels.Produto;

namespace Servico.MapeamentoEntidades
{
    public class PedidoMapeamentoEntidade : IPedidoMapeamentoEntidade
    {
        public Pedido ConstruirCom(PedidoCadastrarViewModel viewModel) =>
      new Pedido
      {
          //ProdutoId = viewModel.ProdutoId,
          ClienteId = viewModel.ClienteId,
          MesaId = viewModel.MesaId,
          Observacao = viewModel.Observacao,
      };
    }
}
