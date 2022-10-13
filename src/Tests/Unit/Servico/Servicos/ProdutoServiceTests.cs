//using NSubstitute;
//using Repositorio.Repositorios;
//using Servico.Servicos;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xunit;

//namespace Testes.Unit.Servico.Servicos
//{
//    public class ProdutoServiceTests
//    {
//        private readonly IProdutoService _produtoService;
//        private readonly IProdutoRepositorio _produtoRepositorio;

//        public ProdutoServiceTests()
//        {
//            // Mock: são objetos que simulam o comportamento de objetos
//            // reais de forma controlada

//            // Mock da interface que o serviço depende
//            _produtoRepositorio = Substitute.For<IProdutoRepositorio>();

//            // Instancia do serviço que será testado
//            _produtoService = new ProdutoService(_produtoRepositorio);
//        }

//        [Fact]
//        public void Test_Apagar()
//        {
//            // Arrange
//            var id = 10;

//            // Act
//            _produtoService.Apagar(id);

//            // Assert
//            // Validar que o método Apagar do Repositório foi chamado
//            // no método Apagar do Serviço, passando como parâmetro o id
//            _racaRepositorio
//                .Received()
//                .Apagar(Arg.Is(10));
//        }

//        [Fact]
//        public void Test_Cadastrar()
//        {
//            // Arrange
//            var viewModel = new RacaCadastrarViewModel
//            {
//                Especie = nameof(Especie.Peixe),
//                Nome = "Tilápia"
//            };

//            // Act
//            _racaServico.Cadastrar(viewModel);

//            // Assert
//            // Validar que o método Cadastrar foi chamado no serviço, passando 
//            // como parâmetro um objeto da raca com os dados do viewModel
//            _racaRepositorio.Received(1).Cadastrar(Arg.Is<Raca>(
//                raca => ValidarRaca(raca, viewModel)));
//        }

//        [Fact]
//        public void Test_ObterPorId_Raca_Nao_Encontrada()
//        {
//            // Arrange
//            var id = 20;

//            // Mock método ObterPorId para retornar null do IRacaRepositorio
//            _racaRepositorio
//                .ObterPorId(Arg.Is(20))
//                .ReturnsNull();

//            // Act
//            var raca = _racaServico.ObterPorId(id);

//            // Assert
//            raca.Should().BeNull();

//            _racaRepositorio
//                .Received(1)
//                .ObterPorId(Arg.Is(20));
//        }

//        [Fact]
//        public void Test_ObterPorId_Raca_Encontrada()
//        {
//            // Arrange
//            var id = 33;

//            var racaEsperada = new Raca
//            {
//                Id = id,
//                Nome = "Pinscher",
//                Especie = nameof(Especie.Cachorro)
//            };

//            _racaRepositorio.ObterPorId(Arg.Is(id))
//                .Returns(racaEsperada);

//            // Act
//            var raca = _racaServico.ObterPorId(id);

//            // Assert
//            raca.Nome.Should().Be(racaEsperada.Nome);
//            raca.Especie.Should().Be(racaEsperada.Especie);
//        }

//        [Fact]
//        public void Test_Editar_Com_Raca_Encontrada()
//        {
//            // Arrange
//            var viewModel = new RacaEditarViewModel
//            {
//                Id = 19,
//                Nome = "   Pinscher caramelo   ",
//                Especie = nameof(Especie.Cachorro)
//            };

//            var racaParaEditar = new Raca
//            {
//                Id = 19,
//                Nome = "Dobermann",
//                Especie = nameof(Especie.Peixe)
//            };

//            _racaRepositorio
//                .ObterPorId(Arg.Is(viewModel.Id))
//                .Returns(racaParaEditar);

//            // Act
//            _racaServico.Editar(viewModel);

//            // Assert
//            _racaRepositorio.Received(1).Atualizar(Arg.Is<Raca>(raca =>
//                ValidarRacaComRacaEditarViewModel(raca, viewModel)));
//        }

//        [Fact]
//        public void Test_Editar_Sem_Raca_Encontrada()
//        {
//            // Arrange
//            var viewModel = new RacaEditarViewModel
//            {
//                Id = 1,
//                Especie = nameof(Especie.Gato),
//                Nome = "Vingador"
//            };

//            _racaRepositorio
//                .ObterPorId(Arg.Is(viewModel.Id))
//                .ReturnsNull();

//            // Act
//            _racaServico.Editar(viewModel);

//            // Assert
//            _racaRepositorio
//                .DidNotReceive()
//                .Atualizar(Arg.Any<Raca>());
//        }

//        private bool ValidarRaca(Raca raca, RacaCadastrarViewModel viewModel)
//        {
//            raca.Nome.Should().Be(viewModel.Nome);
//            //raca.Especie.Should().Be(viewModel.Especie);

//            // Informar que a validação da raça foi executada com sucesso
//            return true;
//        }

//        private bool ValidarRacaComRacaEditarViewModel(
//            Raca raca,
//            RacaEditarViewModel viewModel)
//        {
//            raca.Especie.Should().Be(viewModel.Especie);
//            raca.Id.Should().Be(viewModel.Id);
//            raca.Nome.Should().Be(viewModel.Nome.Trim());

//            return true;
//        }
//    }
//}
