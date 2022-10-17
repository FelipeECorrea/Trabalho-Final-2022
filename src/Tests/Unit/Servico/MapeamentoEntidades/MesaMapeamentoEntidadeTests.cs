using FluentAssertions;
using Repositorio.Entidades;
using Repositorio.Enums;
using Servico.MapeamentoEntidades;
using Servico.ViewModels.Mesa;
using Servico.ViewModels.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Testes.Unit.Servico.MapeamentoEntidades
{
    public class MesaMapeamentoEntidadeTests
    {
        private readonly IMesaMapeamentoEntidade _mesaMapeamentoEntidade;

        public MesaMapeamentoEntidadeTests()
        {
            _mesaMapeamentoEntidade = new MesaMapeamentoEntidade();
        }

        [Fact]
        public void Test_ConstruirCom_()
        {
            // Arrange
            var viewModel = new MesaCadastrarViewModel
            {
                Status = 1,
                NumeroMesa = 1
            };

            // Act
            var mesa = _mesaMapeamentoEntidade.ConstruirCom(viewModel);

            // Assert
            mesa.Status.Should().Be((StatusMesa)viewModel.Status);
            mesa.NumeroMesa.Should().Be(viewModel.NumeroMesa);
        }

        [Fact]
        public void Test_AtualizarCampos()
        {
            // Arrange
            var mesa = new Mesa
            {
                NumeroMesa = 1,
                Status = StatusMesa.Ocupado

            };

            var viewModelEditar = new MesaEditarViewModel
            {
                NumeroMesa = 10,
                Status = 0,
            };

            // Act
            _mesaMapeamentoEntidade.AtualizarCampos(mesa, viewModelEditar);

            // Assert
            mesa.NumeroMesa.Should().Be(viewModelEditar.NumeroMesa);
            mesa.Status.Should().Be((StatusMesa)viewModelEditar.Status);

        }
    }
}
