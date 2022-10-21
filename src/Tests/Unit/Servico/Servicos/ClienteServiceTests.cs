using FluentAssertions;
using NSubstitute;
using NSubstitute.ReturnsExtensions;
using Repositorio.Entidades;
using Repositorio.Repositorios;
using Servico.MapeamentoEntidades;
using Servico.MapeamentoViewModels;
using Servico.Servicos;
using Servico.ViewModels.Cliente;
using Xunit;

namespace Testes.Unit.Servico.Servicos
{
    public class ClienteServiceTests
    {

        private readonly IClienteService _clienteService;
        private readonly IClienteMapeamentoEntidade _clienteMapeamentoEntidade;
        private readonly IClienteRepositorio _clienteRepositorio;
        private readonly IClienteMapeamentoViewModel _clienteMapeamentoViewModel;

        public ClienteServiceTests()
        {

            _clienteRepositorio = Substitute.For<IClienteRepositorio>();
            _clienteMapeamentoEntidade = Substitute.For<IClienteMapeamentoEntidade>();
            _clienteMapeamentoViewModel = Substitute.For<IClienteMapeamentoViewModel>();

            _clienteService = Substitute.For<IClienteService>();

            _clienteService = new ClienteService(_clienteRepositorio,
              _clienteMapeamentoEntidade, _clienteMapeamentoViewModel);
        }

        [Fact]
        public void Test_Cadastrar()
        {
            var viewModel = new ClienteCadastrarViewModel
            {
                Nome = "Marina de Lima",
                Telefone = "(47)98411-7425",
                Email = "marinalimasc@gmail.com",
                Cpf = "909.909.909-07"
            };

            var cliente = new Cliente
            {
                Nome = "Marina de Lima",
                Telefone = "(47)98411-7425",
                Email = "marinalimasc@gmail.com",
                Cpf = "909.909.909-07"
            };

            cliente.Nome.Should().Be(cliente.Nome);
            cliente.Telefone.Should().Be(cliente.Telefone);
            cliente.Email.Should().Be(cliente.Email);
            cliente.Cpf.Should().Be(cliente.Cpf);

        }

        [Fact]
        public void Test_Editar()
        {
            var cliente = new Cliente
            {
                Nome = "Marina de Lima",
                Telefone = "(47)98411-7425",
                Email = "marinalimasc@gmail.com",
                Cpf = "909.909.909-07"
            };

            var clienteEditar = new ClienteEditarViewModel()
            {
                Nome = "Nina de Lima",
                Telefone = "(47)98811-7425",
                Email = "marinaasc@gmail.com",
                Cpf = "908.909.909-07"
            };


        }

        [Fact]
        public void Test_Apagar()
        {
            var id = 2;

            _clienteService.Apagar(id);
            _clienteRepositorio


            .Received()
            .Apagar(Arg.Is(2));
        }

        [Fact]
        public void Test_ObterPorId_Cliente_Nao_Encontrado()
        {
            var id = 30;

            _clienteRepositorio
                .ObterPorId(Arg.Is(30))
                .ReturnsNull();

            var cliente = _clienteService.ObterPorId(id);

            // Assert
            cliente.Should().BeNull();

            _clienteRepositorio
                .Received(1)
                .ObterPorId(Arg.Is(30));

        }

        [Fact]
        public void Test_ObterPorId_Cliente_Encontrado()
        {
            // Arrange
            var id = 30;

            var clienteEsperado = new Cliente
            {
                Nome = "Marina",
                Telefone = "(47)98411-7425",
                Email = "marinalimasc@gmail.com",
                Cpf = "112.428.779-82"

            };

            _clienteRepositorio.ObterPorId(Arg.Is(id))
                .Returns(clienteEsperado);

            // Act
            var cliente = _clienteService.ObterPorId(id);

            // Assert
            cliente.Nome.Should().Be(clienteEsperado.Nome);
            cliente.Telefone.Should().Be(clienteEsperado.Telefone);
            cliente.Email.Should().Be(clienteEsperado.Email);
            cliente.Cpf.Should().Be(clienteEsperado.Cpf);

        }

        [Fact]
        public void Test_Editar_Com_Cliente_Encontrado()
        {
            // Arrange
            var viewModel = new ClienteEditarViewModel
            {
                Nome = "Marina",
                Telefone = "(47)98411-7425",
                Email = "marinalimasc@gmail.com",
                Cpf = "112.428.779-82"
            };

            var clienteParaEditar = new Cliente
            {
                Nome = "Marina",
                Telefone = "(47)98411-7425",
                Email = "marinalimasc@gmail.com",
                Cpf = "112.428.779-82"
            };

            _clienteRepositorio
                .ObterPorId(Arg.Is(viewModel.Id))
                .Returns(clienteParaEditar);

            // Act
            _clienteService.Editar(viewModel);
        }

        [Fact]
        public void Test_Editar_Sem_Cliente_Encontrado()
        {
            // Arrange
            var viewModel = new ClienteEditarViewModel
            {
                Nome = "Marina",
                Telefone = "(47)98411-7425",
                Email = "marinalimasc@gmail.com",
                Cpf = "112.428.779-82"
            };

            _clienteRepositorio
                .ObterPorId(Arg.Is(viewModel.Id))
                .ReturnsNull();

            // Act
            _clienteService.Editar(viewModel);

        }
    }
}


