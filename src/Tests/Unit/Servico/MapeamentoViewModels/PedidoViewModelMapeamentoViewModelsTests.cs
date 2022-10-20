using Repositorio.Entidades;
using Servico.MapeamentoViewModels;
using Xunit;

namespace Testes.Unit.Servico.MapeamentoViewModels
{
    public class PedidoViewModelMapeamentoViewModelsTests
    {
        private readonly IPedidoServiceViewModelMapeamentoViewModels _PedidoViewModelMapeamentoViewModels;

        public PedidoViewModelMapeamentoViewModelsTests()
        {
            _PedidoViewModelMapeamentoViewModels = new PedidoViewModelMapeamentoViewModels();
        }
        [Fact]
        public void Test_ConstruirCom()
        {
            // Arrange
            var pedido = new Pedido
            {
                ClienteId = 1,
                MesaId = 2,
                Observacao = "Com Ketchup"
            };

        }

    }

}
