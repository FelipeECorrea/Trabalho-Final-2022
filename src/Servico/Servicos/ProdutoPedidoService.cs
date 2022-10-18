using Repositorio.Entidades;
using Repositorio.Repositorios;
using Servico.MapeamentoEntidades;
using Servico.ViewModels;
using Servico.ViewModels.ProdutoPedido;

namespace Servico.Servicos
{
    public class ProdutoPedidoService : IProdutoPedidoService
    {
        private readonly IProdutoPedidoRepositorio _produtoPedidoRepositorio;
        private readonly IProdutoPedidoMapeamentoEntidade _mapeamentoEntidade;

        public ProdutoPedidoService()
        {
        }

        public ProdutoPedidoService(
            IProdutoPedidoRepositorio produtoPedidoRepositorio,
            IProdutoPedidoMapeamentoEntidade produtoPedidoMapeamentoEntidade)
        {
            _produtoPedidoRepositorio = produtoPedidoRepositorio;
            _mapeamentoEntidade = produtoPedidoMapeamentoEntidade;
        }

        public void Apagar(int id)
        {
            _produtoPedidoRepositorio.Apagar(id);
        }

        public ProdutoPedido Cadastrar(ProdutoPedidoCadastrarViewModel viewModel)
        {
            var produtoPedido = _mapeamentoEntidade.ConstruirCom(viewModel);

            _produtoPedidoRepositorio.Cadastrar(produtoPedido);

            return produtoPedido;
        }

        public ProdutoPedido ObterPorId(int id)
        {
            var BuscarProdutoPedidoPorId = _produtoPedidoRepositorio.ObterPorId(id);

            return BuscarProdutoPedidoPorId;
        }

        public IList<ProdutoPedido> ObterTodos()
        {
            var produtosPedidosDoBanco = _produtoPedidoRepositorio.ObterTodos();

            return produtosPedidosDoBanco;
        }

        public IList<SelectViewModel> ObterTodosProdutosPedidos()
        {
            var produtosPedidos = _produtoPedidoRepositorio.ObterTodos();

            var selectViewModel = produtosPedidos
                .Select(x => new SelectViewModel
                {
                    Id = x.Id,
                })
                .ToList();

            return selectViewModel;
        }
    }
}
