using Repositorio.Entidades;
using Servico.ViewModels.Pedido;

namespace Servico.MapeamentoViewModels
{
    public class PedidoViewModelMapeamentoViewModels : IPedidoViewModelMapeamentoViewModels
    {
        //public PedidoEditarViewModel ConstruirCom(Pedido Pedido) =>
        //      new PedidoEditarViewModel
        //      {
        //          Id = Pedido.Id,
        //          Nome = Pedido.Nome,
        //          Valor = Pedido.Valor,
        //          Categoria = Pedido.Categoria,
        //          Descricao = Pedido.Descricao
        //      };

        private IList<PedidoViewModel> ConstruirContatosCom(IList<Pedido> Pedidos)
        {
            var viewModels = new List<PedidoViewModel>();

            foreach (var Pedido in Pedidos)
            {
                viewModels.Add(new PedidoViewModel
                {
                    ClienteId = Pedido.ClienteId,
                    MesaId = Pedido.MesaId,
                    ProdutoId = Pedido.ProdutoId,
                    Observacao = Pedido.Observacao

                });
            }
            return viewModels;
        }

    }
}

