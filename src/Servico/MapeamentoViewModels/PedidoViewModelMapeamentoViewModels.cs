using Repositorio.Entidades;
using Servico.ViewModels.Pedido;

namespace Servico.MapeamentoViewModels
{
    public class PedidoViewModelMapeamentoViewModels : IPedidoServiceViewModelMapeamentoViewModels
    {
        public PedidoCadastrarViewModel ConstruirCom(Pedido Pedido) =>
              new PedidoCadastrarViewModel
              {
                  ClienteId = Pedido.ClienteId,
                  MesaId = Pedido.MesaId,
              };

    }
}

