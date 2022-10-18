using FluentAssertions;
using Repositorio.Entidades;
using Servico.MapeamentoViewModels;
using Xunit;

namespace Testes.Unit.Servico.MapeamentoViewModels
{
    public class ClienteViewModelMapeamentoViewModelsTests
    {
        private readonly IClienteMapeamentoViewModel _clienteViewModelMapeamentoViewModel;

        public ClienteViewModelMapeamentoViewModelsTests()
        {
            _clienteViewModelMapeamentoViewModel = new ClienteViewModelMapeamentoViewModel();
        }

        [Fact]
        public void Construir_Com()
        {
            var cliente = new Cliente()
            {
                Nome = "Marina de Lima",
                Telefone = "(47)98411-7425",
                Email = "marinalimasc@gmail.com",
                Cpf = "984.742.909-02"

            };

            var clienteEditarViewModel = _clienteViewModelMapeamentoViewModel
                .ConstruirCom(cliente);

            clienteEditarViewModel.Nome.Should().Be(cliente.Nome);
            clienteEditarViewModel.Telefone.Should().Be(cliente.Telefone);
            clienteEditarViewModel.Email.Should().Be(cliente.Email);
            clienteEditarViewModel.Cpf.Should().Be(cliente.Cpf);

        }

    }
}
