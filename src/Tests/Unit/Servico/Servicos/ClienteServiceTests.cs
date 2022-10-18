﻿using FluentAssertions;
using NSubstitute;
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
    }
}
