//using FluentAssertions;
//using NSubstitute;
//using NSubstitute.ReturnsExtensions;
//using Repositorio.Entidades;
//using Repositorio.Enums;
//using Repositorio.Repositorios;
//using Servico.MapeamentoEntidades;
//using Servico.MapeamentoViewModels;
//using Servico.Servicos;
//using Servico.ViewModels.Mesa;
//using Servico.ViewModels.Pedido;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xunit;

//namespace Testes.Unit.Servico.Servicos
//{
//    public class PedidoServiceTests
//    {
//        private readonly IPedidoService _pedidoService;
//        private readonly IPedidoRepositorio _pedidoRepositorio;
//        private readonly IPedidoMapeamentoEntidade _mapeamentoEntidade;
//        private readonly IPedidoViewModelMapeamentoViewModels _mapeamentoViewModel;

//        public PedidoServiceTests()
//        {
//            // Mock: são objetos que simulam o comportamento de objetos
//            // reais de forma controlada

//            // Mock da interface que o serviço depende
//            _pedidoRepositorio = Substitute.For<IPedidoRepositorio>();
//            _mapeamentoEntidade = Substitute.For<IPedidoMapeamentoEntidade>();
//            _mapeamentoViewModel = Substitute.For<IPedidoViewModelMapeamentoViewModels>();

//            // Instancia do serviço que será testado
//            _pedidoService = new PedidoService(_pedidoRepositorio,
//                _mapeamentoEntidade,
//                _mapeamentoViewModel);
//        }

//        [Fact]
//        public void Test_Apagar()
//        {
//            // Arrange
//            var id = 10;

//            // Act
//            _pedidoService.Apagar(id);

//            // Assert
//            // Validar que o método Apagar do Repositório foi chamado
//            // no método Apagar do Serviço, passando como parâmetro o id
//            _pedidoRepositorio
//                .Received()
//                .Apagar(Arg.Is(10));
//        }

//        [Fact]
//        public void Test_Cadastrar()
//        {
//            // Arrange
//            var viewModel = new PedidoCadastrarViewModel
//            {
//                ClienteId = 1,
//                MesaId = 2,
//                Observacao = "Com Ketchup"
//            };

//            var pedido = new Pedido
//            {
//                ClienteId = 1,
//                MesaId = 2,
//                Observacao = "Com Ketchup"
//            };

//            _mapeamentoEntidade
//                .ConstruirCom(Arg.Is<PedidoCadastrarViewModel>(
//                    x => x.ClienteId == viewModel.ClienteId && x.MesaId == viewModel.MesaId && x.Observacao == viewModel.Observacao))
//                .Returns(pedido);

//            // Act
//            _pedidoService.Cadastrar(viewModel);

//            // Assert
//            // Validar que o método Cadastrar foi chamado no serviço, passando 
//            // como parâmetro um objeto da raca com os dados do viewModel
//            _pedidoRepositorio.Received(1).Cadastrar(Arg.Is<Pedido>(
//                pedido => ValidarPedido(pedido, viewModel)));
//        }

//        [Fact]
//        public void Test_ObterPorId_Pedido_Nao_Encontrada()
//        {
//            // Arrange
//            var id = 20;

//            // Mock método ObterPorId para retornar null do IRacaRepositorio
//            _pedidoRepositorio
//                .ObterPorId(Arg.Is(20))
//                .ReturnsNull();

//            // Act
//            var pedido = _pedidoService.ObterPorId(id);

//            // Assert
//            pedido.Should().BeNull();

//            _pedidoRepositorio
//                .Received(1)
//                .ObterPorId(Arg.Is(20));
//        }

//        [Fact]
//        public void Test_ObterPorId_Pedido_Encontrada()
//        {
//            // Arrange
//            var id = 33;

//            var pedidoEsperada = new Pedido
//            {
//                Id = id,
//                ClienteId = 1,
//                MesaId = 2,
//                Observacao = "Com Ketchup"
//            };

//            _pedidoRepositorio.ObterPorId(Arg.Is(id))
//                .Returns(pedidoEsperada);

//            // Act
//            var pedido = _pedidoService.ObterPorId(id);

//            // Assert
//            pedido.ClienteId.Should().Be(pedidoEsperada.ClienteId);
//            pedido.MesaId.Should().Be(pedidoEsperada.MesaId);
//            pedido.Observacao.Should().Be(pedidoEsperada.Observacao);

//        }

//        [Fact]
//        public void Test_Editar_Com_Pedido_Encontrada()
//        {
//            // Arrange
//            var viewModel = new PedidoEditarViewModel
//            {
//                ClienteId = 1,
//                MesaId = 2,
//                Observacao = "Com Ketchup"
//            };

//            var mesaParaEditar = new Mesa
//            {
//                ClienteId = 1,
//                MesaId = 2
               
//            };

//            _pedidoRepositorio
//                .ObterPorId(Arg.Is(viewModel.Id))
//                .Returns(mesaParaEditar);

//            // Act
//            _pedidoService.Editar(viewModel);
//        }

//        [Fact]
//        public void Test_Editar_Sem_Pedido_Encontrada()
//        {
//            // Arrange
//            var viewModel = new PedidoEditarViewModel
//            {
//                ClienteId = 1,
//                MesaId = 2,
//                Observacao = "Com Ketchup"
//            };

//            _pedidoRepositorio
//                .ObterPorId(Arg.Is(viewModel.Id))
//                .ReturnsNull();

//            // Act
//            _pedidoService.Editar(viewModel);

//        }

//        private bool ValidarPedido(Pedido pedido, PedidoCadastrarViewModel viewModel)
//        {
//            pedido.ClienteId.Should().Be(viewModel.ClienteId);
//            pedido.MesaId.Should().Be(viewModel.MesaId);
//            pedido.Observacao.Should().Be(viewModel.Observacao);

//            // Informar que a validação da raça foi executada com sucesso
//            return true;
//        }

//        private bool ValidarPedidoComPedidoEditarViewModel(
//            Pedido pedido,
//            PedidoEditarViewModel viewModel)
//        {
//            pedido.ClienteId.Should().Be(viewModel.ClienteId);
//            pedido.MesaId.Should().Be(viewModel.MesaId);
//            pedido.Observacao.Should().Be(viewModel.Observacao);

//            return true;
//        }
//    }
//}
