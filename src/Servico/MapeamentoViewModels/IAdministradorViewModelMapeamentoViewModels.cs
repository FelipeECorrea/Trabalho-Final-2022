using Repositorio.Entidades;
using Servico.ViewModels.Administrador;

namespace Servico.MapeamentoViewModels
{
    public interface IAdministradorViewModelMapeamentoViewModels
    {
        AdministradorEditarViewModel ConstruirCom(Administrador administrador);
    }
}
