using Repositorio.Entidades;
using Servico.ViewModels.Pedido;

namespace Servico.MapeamentoViewModels
{
    public class PedidoViewModelMapeamentoViewModels : IPedidoViewModelMapeamentoViewModels
    {
        public PedidoCadastrarViewModel ConstruirCom(Pedido Pedido) =>
              new PedidoCadastrarViewModel
              {
                  ClienteId = Pedido.ClienteId,
                  ProdutoId = Pedido.ProdutoId,
                  MesaId = Pedido.MesaId,
                  Observacao = Pedido.Observacao
              };

    }
}

