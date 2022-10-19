using NSubstitute;
using Repositorio.Repositorios;
using Servico.MapeamentoEntidades;
using Servico.MapeamentoViewModels;
using Servico.Servicos;
using Servico.ViewModels.ProdutoPedido;
using Xunit;

namespace Testes.Unit.Servico.Servicos
{
    public class ProdutoPedidoServiceTests
    {

        private readonly IProdutoPedidoService _produtoPedidoService;
        private readonly IProdutoPedidoRepositorio _produtoPedidoRepositorio;
        private readonly IProdutoPedidoViewModelMapeamentoViewModels _ProdutoPedidoMapeamentoViewModels;
        private readonly IProdutoPedidoMapeamentoEntidade _ProdutoPedidoMapeamentoEntidade;

        public ProdutoPedidoServiceTests()
        {
            //Mocks

            _produtoPedidoRepositorio = Substitute.For<IProdutoPedidoRepositorio>();
            _ProdutoPedidoMapeamentoEntidade = Substitute.For<IProdutoPedidoMapeamentoEntidade>();
            _ProdutoPedidoMapeamentoViewModels = Substitute.For<IProdutoPedidoViewModelMapeamentoViewModels>();

            _produtoPedidoService = new ProdutoPedidoService(_produtoPedidoRepositorio,
                _ProdutoPedidoMapeamentoEntidade);

        }

        [Fact]
        public void Cadastrar_Produto_Pedido()
        {
            var viewModel = new ProdutoPedidoCadastrarViewModel()
            {
                PedidoId = 1,
                ProdutoId = 2,
                Quantidade = 4,

            };
        }

    }
}
