using Repositorio.Entidades;
using Servico.ViewModels.Cliente;

namespace Servico.Servicos
{
    public interface IClienteService
    {
        bool Apagar(int id);
        Cliente Cadastrar(ClienteCadastrarViewModel viewModel, string caminhoArquivo);
        bool Editar(ClienteEditarViewModel viewModel, string caminhoArquivos);
        Cliente? ObterPorId(int id);
        IList<Cliente> ObterTodos();
    }
}
