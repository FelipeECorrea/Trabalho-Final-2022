

using FluentAssertions;
using NSubstitute;
using NSubstitute.ReturnsExtensions;
using Repositorio.Entidades;
using Repositorio.Enums;
using Repositorio.Repositorios;
using Servico.MapeamentoEntidades;
using Servico.MapeamentoViewModels;
using Servico.Servicos;
using Servico.ViewModels.Mesa;
using Xunit;

namespace Testes.Unit.Servico.Servicos
{
    public class MesaServiceTests
    {
        private readonly IMesaService _mesaService;
        private readonly IMesaRepositorio _mesaRepositorio;
        private readonly IMesaMapeamentoEntidade _mapeamentoEntidade;
        private readonly IMesaViewModelMapeamentoViewModels _mapeamentoViewModel;

        public MesaServiceTests()
        {
            // Mock: são objetos que simulam o comportamento de objetos
            // reais de forma controlada

            // Mock da interface que o serviço depende
            _mesaRepositorio = Substitute.For<IMesaRepositorio>();
            _mapeamentoEntidade = Substitute.For<IMesaMapeamentoEntidade>();
            _mapeamentoViewModel = Substitute.For<IMesaViewModelMapeamentoViewModels>();

            // Instancia do serviço que será testado
            _mesaService = new MesaService(_mesaRepositorio,
                _mapeamentoEntidade,
                _mapeamentoViewModel);
        }

        [Fact]
        public void Test_Apagar()
        {
            // Arrange
            var id = 10;

            // Act
            _mesaService.Apagar(id);

            // Assert
            // Validar que o método Apagar do Repositório foi chamado
            // no método Apagar do Serviço, passando como parâmetro o id
            _mesaRepositorio
                .Received()
                .Apagar(Arg.Is(10));
        }

        [Fact]
        public void Test_Cadastrar()
        {
            // Arrange
            var viewModel = new MesaCadastrarViewModel
            {
                NumeroMesa = 10,
                Status = 1
            };

            var mesa = new Mesa
            {
                NumeroMesa = 10,
                Status = Repositorio.Enums.StatusMesa.Ocupado
            };

            _mapeamentoEntidade
                .ConstruirCom(Arg.Is<MesaCadastrarViewModel>(
                    x => x.NumeroMesa == viewModel.NumeroMesa && x.Status == viewModel.Status))
                .Returns(mesa);

            // Act
            _mesaService.Cadastrar(viewModel);

            // Assert
            // Validar que o método Cadastrar foi chamado no serviço, passando 
            // como parâmetro um objeto da raca com os dados do viewModel
            _mesaRepositorio.Received(1).Cadastrar(Arg.Is<Mesa>(
                mesa => ValidarMesa(mesa, viewModel)));
        }

        [Fact]
        public void Test_ObterPorId_Mesa_Nao_Encontrada()
        {
            // Arrange
            var id = 20;

            // Mock método ObterPorId para retornar null do IRacaRepositorio
            _mesaRepositorio
                .ObterPorId(Arg.Is(20))
                .ReturnsNull();

            // Act
            var mesa = _mesaService.ObterPorId(id);

            // Assert
            mesa.Should().BeNull();

            _mesaRepositorio
                .Received(1)
                .ObterPorId(Arg.Is(20));
        }

        [Fact]
        public void Test_ObterPorId_Mesa_Encontrada()
        {
            // Arrange
            var id = 33;

            var mesaEsperada = new Mesa
            {
                Id = id,
                NumeroMesa = 1
            };

            _mesaRepositorio.ObterPorId(Arg.Is(id))
                .Returns(mesaEsperada);

            // Act
            var mesa = _mesaService.ObterPorId(id);

            // Assert
            mesa.NumeroMesa.Should().Be(mesaEsperada.NumeroMesa);

        }

        [Fact]
        public void Test_Editar_Com_Mesa_Encontrada()
        {
            // Arrange
            var viewModel = new MesaEditarViewModel
            {
                NumeroMesa = 1
            };

            var mesaParaEditar = new Mesa
            {
                NumeroMesa = 1
            };

            _mesaRepositorio
                .ObterPorId(Arg.Is(viewModel.Id))
                .Returns(mesaParaEditar);

            // Act
            _mesaService.Editar(viewModel);
        }

        [Fact]
        public void Test_Editar_Sem_Mesa_Encontrada()
        {
            // Arrange
            var viewModel = new MesaEditarViewModel
            {
                NumeroMesa = 1,
            };

            _mesaRepositorio
                .ObterPorId(Arg.Is(viewModel.Id))
                .ReturnsNull();

            // Act
            _mesaService.Editar(viewModel);

        }

        private bool ValidarMesa(Mesa mesa, MesaCadastrarViewModel viewModel)
        {
            mesa.NumeroMesa.Should().Be(viewModel.NumeroMesa);
            mesa.Status.Should().Be((StatusMesa)viewModel.Status);

            // Informar que a validação da raça foi executada com sucesso
            return true;
        }

        private bool ValidarMesaComMesaEditarViewModel(
            Mesa mesa,
            MesaEditarViewModel viewModel)
        {
            mesa.NumeroMesa.Should().Be(viewModel.NumeroMesa);


            return true;
        }
    }
}
