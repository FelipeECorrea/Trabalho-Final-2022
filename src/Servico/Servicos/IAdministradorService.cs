using Repositorio.Entidades;
using Servico.ViewModels;
using Servico.ViewModels.Administrador;

namespace Servico.Servicos
{
    public interface IAdministradorService
    {
        bool Apagar(int id);
        Administrador Cadastrar(AdministradorCadastrarViewModel viewModel);
        bool Editar(AdministradorEditarViewModel viewModel);
        Administrador? ObterPorId(int id);
        IList<Administrador> Cadastrar();
        IList<SelectViewModel> ObterPorSelect2();
        Administrador? ObterPorEmail(string Email);
        bool SenhaValida(string senha);
    }
}
