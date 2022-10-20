using Repositorio.Entidades;
using Servico.MapeamentoViewModels;
using Xunit;

namespace Testes.Unit.Servico.MapeamentoViewModels
{
    public class ProdutoPedidoViewModelMapeamentoViewModelsTests
    {

        private readonly IProdutoPedidoViewModelMapeamentoViewModels _produtoPedidoMapeamentoViewModel;

        public ProdutoPedidoViewModelMapeamentoViewModelsTests()
        {
            _produtoPedidoMapeamentoViewModel = new ProdutoPedidoViewModelMapeamentoViewModels();
        }

        [Fact]
        public void Test_Construir_Com()
        {
            var produtoPedido = new ProdutoPedido()
            {
                PedidoId = 1,
                ProdutoId = 1,
                Valor = 45.9m,
                Quantidade = 12
            };
        }
    }
}
