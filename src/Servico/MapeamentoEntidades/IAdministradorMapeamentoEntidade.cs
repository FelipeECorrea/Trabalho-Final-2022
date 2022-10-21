using Repositorio.Entidades;
using Servico.ViewModels.Administrador;

namespace Servico.MapeamentoEntidades
{
    public interface IAdministradorMapeamentoEntidade
    {
        Administrador ConstruirCom(AdministradorCadastrarViewModel viewModel);
        void AtualizarCom(Administrador administrador, AdministradorEditarViewModel administradorEditarViewModel);
    }
}
