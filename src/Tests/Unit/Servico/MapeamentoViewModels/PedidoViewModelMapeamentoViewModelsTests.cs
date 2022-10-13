using FluentAssertions;
using Repositorio.Entidades;
using Servico.MapeamentoViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Testes.Unit.Servico.MapeamentoViewModels
{
    public class PedidoViewModelMapeamentoViewModelsTests
    {
        private readonly IPedidoViewModelMapeamentoViewModels _PedidoViewModelMapeamentoViewModels;

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
            // Act
            var pedidoEditarViewModel = _PedidoViewModelMapeamentoViewModels
                .ConstruirCom(pedido);

            // Assert
            pedidoEditarViewModel.ClienteId.Should().Be(pedido.ClienteId);
            pedidoEditarViewModel.MesaId.Should().Be(pedido.MesaId);

        }

    }
       
}
