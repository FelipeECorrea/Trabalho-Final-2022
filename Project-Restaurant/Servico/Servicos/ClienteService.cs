using Repositorio.BancoDados;
using Repositorio.Entidades;
using Repositorio.Repositorios;
using Servico.MapeamentoEntidades;
using Servico.ViewModels;
using Servico.ViewModels.Cliente;

namespace Servico.Servicos
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        private readonly IClienteMapeamentoEntidade _mapeamentoEntidade;
        private readonly RestauranteContexto _contexto;

        public ClienteService(
            IClienteRepositorio clienteRepositorio,
            IClienteMapeamentoEntidade mapeamentoEntidade)
        {
            _clienteRepositorio = clienteRepositorio;
            _mapeamentoEntidade = mapeamentoEntidade;
        }

        public bool Apagar(int id) =>
            _clienteRepositorio.Apagar(id);

        public Cliente Cadastrar(ClienteCadastrarViewModel viewModel)
        {
            var cliente = _mapeamentoEntidade.ConstruirCom(viewModel);

            _clienteRepositorio.Cadastrar(cliente);

            return cliente;
        }

        public bool Editar(ClienteEditarViewModel viewModel)
        {
            var cliente = _clienteRepositorio.ObterPorId(viewModel.Id);

            if (cliente == null)
                return false;

            _mapeamentoEntidade.AtualizarCom(cliente, viewModel);

            _clienteRepositorio.Editar(cliente);

            return true;
        }

        public Cliente ObterPorEmail(string Email)
        {
            Cliente cliente = _clienteRepositorio.ObterPorEmail(Email);

            return cliente;
        }

        public Cliente? ObterPorId(int id) =>
            _clienteRepositorio.ObterPorId(id);

        public IList<SelectViewModel> ObterPorSelect2()
        {
            var clientes = _clienteRepositorio.ObterTodos();

            var selectViewModels = clientes
                .Select(x => new SelectViewModel
                {
                    Id = x.Id,
                    Text = x.Nome
                })
                .ToList();

            return selectViewModels;
        }

        public IList<Cliente> Cadastrar() =>
            _clienteRepositorio.ObterTodos();

        public bool SenhaValida(string senha)
        {
            Cliente cliente = _clienteRepositorio

            return cliente.Senha == senha;
        }
    }
}
