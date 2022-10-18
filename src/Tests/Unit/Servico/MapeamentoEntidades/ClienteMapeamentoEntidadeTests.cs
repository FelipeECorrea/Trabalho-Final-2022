using FluentAssertions;
using Repositorio.Entidades;
using Servico.MapeamentoEntidades;
using Servico.ViewModels.Cliente;
using Xunit;

namespace Testes.Unit.Servico.MapeamentoEntidades
{
    public class ClienteMapeamentoEntidadeTests
    {
        private readonly IClienteMapeamentoEntidade _clienteMapeamentoEntidade;

        public ClienteMapeamentoEntidadeTests()
        {
            _clienteMapeamentoEntidade = new ClienteMapeamentoEntidade();
        }

        [Fact]
        public void Test_Construir_Com()
        {

            var viewModel = new ClienteCadastrarViewModel
            {
                Nome = "Marina de Lima",
                Telefone = "(47)98411-7425",
                Email = "marinalimasc@gmail.com",
                Cpf = "112.429.770-01"
            };

            var cliente = _clienteMapeamentoEntidade.ConstruirCom(viewModel);

            cliente.Nome.Should().Be(viewModel.Nome);
            cliente.Telefone.Should().Be(viewModel.Telefone);
            cliente.Email.Should().Be(viewModel.Email);
            cliente.Cpf.Should().Be(viewModel.Cpf);

        }

        [Fact]
        public void Atualizar_Com()
        {


            var cliente = new Cliente()
            {
                Nome = "Marina de Lima",
                Telefone = "(47)98411-7425",
                Email = "marinalimasc@gmail.com",
                Cpf = "112.429.770-01"

            };

            var viewModelEditar = new ClienteEditarViewModel
            {
                Nome = "Maria Lima",
                Telefone = "(48)91231_9078",
                Email = "marinalima@bol.com.br",
                Cpf = "890.789.098-02"
            };

            _clienteMapeamentoEntidade.AtualizarCom(cliente, viewModelEditar);

            cliente.Nome.Should().Be(viewModelEditar.Nome);
            cliente.Telefone.Should().Be(viewModelEditar.Telefone);
            cliente.Email.Should().Be(viewModelEditar.Email);
            cliente.Cpf.Should().Be(viewModelEditar.Cpf);
        }


    }

}
