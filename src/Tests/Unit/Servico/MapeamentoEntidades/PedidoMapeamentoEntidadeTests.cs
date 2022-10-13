using FluentAssertions;
using Repositorio.Entidades;
using Servico.MapeamentoEntidades;
using Servico.ViewModels.Pedido;
using Xunit;

namespace Testes.Unit.Servico.MapeamentoEntidades
{
    public class PedidoMapeamentoEntidadeTests
    {
        private readonly IPedidoMapeamentoEntidade _pedidoMapeamentoEntidade;

        public PedidoMapeamentoEntidadeTests()
        {
            _pedidoMapeamentoEntidade = new PedidoMapeamentoEntidade();
        }

        [Fact]
        public void Test_ConstruirCom_()
        {
            // Arrange
            var viewModel = new PedidoCadastrarViewModel
            {
                ClienteId = 1,
                MesaId = 2
            };

            // Act
            _pedidoMapeamentoEntidade.ConstruirCom(viewModel);

            // Assert
            viewModel.ClienteId.Should().Be(viewModel.ClienteId);
            viewModel.MesaId.Should().Be(viewModel.MesaId);
        }

    }
}
