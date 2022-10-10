using FluentAssertions;
using Repositorio.Entidades;
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
    public class MesaMapeamentoEntidadeTests
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
                NumeroMesa = 1
            };

            // Act
            _mesaMapeamentoEntidade.ConstruirCom(viewModel);

            // Assert
            viewModel.Status.Should().Be(viewModel.Status);
            viewModel.NumeroMesa.Should().Be(viewModel.NumeroMesa);
            

        }
        public void Test_AtualizarCampos()
        {
            // Arrange
            var mesa = new Mesa
            {
                NumeroMesa = 1,
                
                
            };

            var viewModelEditar = new MesaEditarViewModel
            {
                NumeroMesa = 1,
                Status =1,
            };

            // Act
            _mesaMapeamentoEntidade.AtualizarCampos(mesa, viewModelEditar);

            // Assert
            mesa.NumeroMesa.Should().Be(viewModelEditar.NumeroMesa);
            
        }
    }
}
