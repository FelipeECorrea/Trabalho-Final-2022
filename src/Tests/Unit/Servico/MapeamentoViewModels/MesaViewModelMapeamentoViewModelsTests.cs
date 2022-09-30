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
    public class MesaViewModelMapeamentoViewModelsTests
    {
        private readonly IMesaViewModelMapeamentoViewModels _MesaViewModelMapeamentoViewModels;

        public MesaViewModelMapeamentoViewModelsTests()
        {
            _MesaViewModelMapeamentoViewModels = new MesaViewModelMapeamentoViewModels();
        }
        [Fact]
        public void Test_ConstruirCom_Sem_Contatos()
        {
            // Arrange
            var mesa = new Mesa
            {
                NumeroMesa = 1,   
            };
            // Act
            var mesaEditarViewModel = _MesaViewModelMapeamentoViewModels
                .ConstruirCom(mesa);
            // Assert
            mesaEditarViewModel.NumeroMesa.Should().Be(mesa.NumeroMesa);
        }
    }
}

