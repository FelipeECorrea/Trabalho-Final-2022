using FluentAssertions;
using Repositorio.Entidades;
using Repositorio.Enums;
using Servico.MapeamentoEntidades;
using Servico.ViewModels.Mesa;
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
                ClienteId= 1,
                MesaId = 1
            };

            // Act
            var pedido = _pedidoMapeamentoEntidade.ConstruirCom(viewModel);

            // Assert
            pedido.ClienteId.Should().Be(viewModel.ClienteId);
            pedido.MesaId.Should().Be(viewModel.MesaId);
        }

    }
}
