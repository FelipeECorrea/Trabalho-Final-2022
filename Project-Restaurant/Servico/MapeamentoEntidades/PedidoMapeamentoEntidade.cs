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
          ClienteId = viewModel.ClienteId,
          MesaId = viewModel.MesaId,
          Observacao = viewModel.Observacao,
      };
    }
}
