using Repositorio.Entidades;
using Servico.ViewModels;
using Servico.ViewModels.Cliente;

namespace Servico.Servicos
{
    public interface IClienteService
    {
        bool Apagar(int id);
        Cliente Cadastrar(ClienteCadastrarViewModel viewModel);
        bool Editar(ClienteEditarViewModel viewModel);
        Cliente? ObterPorId(int id);
        IList<Cliente> Cadastrar();
        IList<SelectViewModel> ObterPorSelect2();
        public Cliente ObterPorEmail(string Email);
        bool SenhaValida(string senha);
    }
}
