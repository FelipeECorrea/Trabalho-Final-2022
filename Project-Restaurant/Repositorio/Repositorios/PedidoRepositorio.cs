using Microsoft.EntityFrameworkCore;
using Repositorio.BancoDados;
using Repositorio.Entidades;

namespace Repositorio.Repositorios
{
    public class PedidoRepositorio : IPedidoRepositorio
    {
        private readonly RestauranteContexto _contexto;

        public PedidoRepositorio(RestauranteContexto contexto)
        {
            _contexto = contexto;
        }

        public Pedido Cadastrar(Pedido pedido)
        {
            _contexto.Pedidos.Add(pedido);
            _contexto.SaveChanges();

            return pedido;
        }

        public Pedido? Apagar(int id)
        {
            var pedidoParaApagar = _contexto.Pedidos
                .FirstOrDefault(x => x.Id == id);

            if (pedidoParaApagar == null)
                return null;

            _contexto.Pedidos.Remove(pedidoParaApagar);
            _contexto.SaveChanges();

            return pedidoParaApagar;
        }

        public void Editar(Pedido pedido)
        {
            _contexto.Pedidos.Update(pedido);
            _contexto.SaveChanges();
        }

        public Pedido? ObterPodId(int pedidoId) =>
            _contexto.Pedidos.FirstOrDefault(x => x.Id == pedidoId);

        public IList<Pedido> ObterTodos() =>
            _contexto.Pedidos
            .Include(x => x.Cliente)
            .Include(x => x.Mesa)
            .ToList();
    }
}
