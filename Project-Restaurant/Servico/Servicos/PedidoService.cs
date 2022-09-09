using Repositorio.Entidades;
using Repositorio.Mapeamentos;
using Repositorio.Repositorios;
using Servico.ViewModels;
using Servico.ViewModels.Pedido;

namespace Servico.Servicos
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepositorio _pedidoRepositorio;

        public void Apagar(int id)
        {
            _pedidoRepositorio.Apagar(id);
        }

        public void Cadastrar(PedidoCadastrarViewModel pedidoCadastrarViewModel)
        {
            throw new NotImplementedException();
        }

        public Pedido ObterPorId(int pedidoId)
        {
            var BuscarPedidoPorId = _pedidoRepositorio.ObterPorId(pedidoId);

            return BuscarPedidoPorId;
        }

        public IList<Pedido> ObterTodos()
        {
            var pedidosDoBanco = _pedidoRepositorio.ObterTodos();

            return pedidosDoBanco;
        }

        public IList<SelectViewModel> ObterTodosPedidos()
        {
            var pedidos = _pedidoRepositorio.ObterTodos();

            var selectViewModel = pedidos
                .Select(x => new SelectViewModel
                {
                    Id = x.Id,
                })
                .ToList();

            return selectViewModel;
        }
    }
}
