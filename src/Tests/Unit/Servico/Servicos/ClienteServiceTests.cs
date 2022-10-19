//using FluentAssertions;
//using NSubstitute;
//using Repositorio.Entidades;
//using Repositorio.Repositorios;
//using Servico.MapeamentoEntidades;
//using Servico.MapeamentoViewModels;
//using Servico.Servicos;
//using Servico.ViewModels.Cliente;
//using Servico.ViewModels.Mesa;
//using Xunit;

//namespace Testes.Unit.Servico.Servicos
//{
//    public class ClienteServiceTests
//    {

//        private readonly IClienteService _clienteService;
//        private readonly IClienteMapeamentoEntidade _clienteMapeamentoEntidade;
//        private readonly IClienteRepositorio _clienteRepositorio;
//        private readonly IClienteMapeamentoViewModel _clienteMapeamentoViewModel;

//        public ClienteServiceTests()
//        {

//            _clienteRepositorio = Substitute.For<IClienteRepositorio>();
//            _clienteMapeamentoEntidade = Substitute.For<IClienteMapeamentoEntidade>();
//            _clienteMapeamentoViewModel = Substitute.For<IClienteMapeamentoViewModel>();

//            _clienteService = Substitute.For<IClienteService>();

//            _clienteService = new ClienteService(_clienteRepositorio,
//              _clienteMapeamentoEntidade, _clienteMapeamentoViewModel);
//        }

//        [Fact]
//        public void Test_Cadastrar()
//        {
//            var viewModel = new ClienteCadastrarViewModel
//            {
//                Nome = "Marina de Lima",
//                Telefone = "(47)98411-7425",
//                Email = "marinalimasc@gmail.com",
//                Cpf = "909.909.909-07"
//            };

//            var cliente = new Cliente
//            {
//                Nome = "Marina de Lima",
//                Telefone = "(47)98411-7425",
//                Email = "marinalimasc@gmail.com",
//                Cpf = "909.909.909-07"
//            };

//            _clienteMapeamentoEntidade
//                .ConstruirCom(Arg.Is<ClienteCadastrarViewModel>(
//                    x => x.NumeroMesa == viewModel.NumeroMesa && x.Status == viewModel.Status))
//                .Returns(mesa);

//            // Act
//            _mesaService.Cadastrar(viewModel);

//            // Assert
//            // Validar que o método Cadastrar foi chamado no serviço, passando 
//            // como parâmetro um objeto da raca com os dados do viewModel
//            _mesaRepositorio.Received(1).Cadastrar(Arg.Is<Mesa>(
//                mesa => ValidarMesa(mesa, viewModel)));

//        }

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
