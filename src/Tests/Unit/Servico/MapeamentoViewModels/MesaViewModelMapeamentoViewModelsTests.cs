using FluentAssertions;
using Repositorio.Entidades;
using Servico.MapeamentoViewModels;
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
        public void Test_ConstruirCom()
        {
            // Arrange
            var mesa = new Mesa
            {
                NumeroMesa = 1, 
                Status = Repositorio.Enums.StatusMesa.Ocupado
            };
            // Act
            var mesaEditarViewModel = _MesaViewModelMapeamentoViewModels
                .ConstruirCom(mesa);
            // Assert
            mesaEditarViewModel.NumeroMesa.Should().Be(mesa.NumeroMesa);
        }
    }
}

