using FluentAssertions;
using Servico.MapeamentoEntidades;
using Servico.ViewModels.Mesa;
using Servico.ViewModels.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.Unit.Servico.MapeamentoEntidades
{
    internal class MesaMapeamentoEntidadeTests
    {
        private readonly IMesaMapeamentoEntidade _mesaMapeamentoEntidade;

        public MesaMapeamentoEntidadeTests()
        {
            _mesaMapeamentoEntidade = new MesaMapeamentoEntidade();
        }
        public void Test_ConstruirCom_()
        {
            // Arrange
            var viewModel = new MesaCadastrarViewModel
            {
                Status = 1,
                NumeroMesa = 2
            };

            // Act
            _mesaMapeamentoEntidade.ConstruirCom(viewModel);

            // Assert
            viewModel.Status.Should().Be(viewModel.Status);
            viewModel.NumeroMesa.Should().Be(viewModel.NumeroMesa);
            

        }
    }
}
