using Repositorio.Entidades;
using Repositorio.Repositorios;
using Servico.ViewModels.Cliente;

namespace Servico.Servicos
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepositorio clienteRepositorio;
        //private readonly IClienteMapeamentoEntidade

        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente Cadastrar(ClienteCadastrarViewModel viewModel, string caminhoArqeuivo)
        {
            throw new NotImplementedException();
        }

        public Cliente? ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
