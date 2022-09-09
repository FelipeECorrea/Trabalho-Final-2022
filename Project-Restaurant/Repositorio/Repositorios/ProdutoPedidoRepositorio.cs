using Microsoft.EntityFrameworkCore;
using Repositorio.BancoDados;
using Repositorio.Entidades;

namespace Repositorio.Repositorios
{
    public class ProdutoPedidoRepositorio : IProdutoPedidoRepositorio
    {
        private readonly RestauranteContexto _contexto;

        public ProdutoPedidoRepositorio(RestauranteContexto contexto)
        {
            _contexto = contexto;
        }

        public bool Apagar(int id)
        {
            var produtoPedido = _contexto.ProdutosPedidos
            .FirstOrDefault(x => x.Id == id);

            if (produtoPedido == null)
                return false;

            _contexto.ProdutosPedidos.Remove(produtoPedido);
            _contexto.SaveChanges();

            return true;
        }

        public ProdutoPedido Cadastrar(ProdutoPedido produtoPedido)
        {
            _contexto.ProdutosPedidos.Add(produtoPedido);
            _contexto.SaveChanges();

            return produtoPedido;
        }

        public void Editar(ProdutoPedido produtoPedido)
        {
            _contexto.ProdutosPedidos.Update(produtoPedido);
            _contexto.SaveChanges();
        }

        public ProdutoPedido? ObterPorId(int id) =>
            _contexto.ProdutosPedidos
            .Include(x => x.Produto)
            .Include(x => x.Pedido)
            .FirstOrDefault(x => x.Id == id);

        public IList<ProdutoPedido> ObterTodos() =>
            _contexto.ProdutosPedidos
            .Include(x => x.Produto)
            .Include(x => x.Pedido)
            .ToList();
    }
}
