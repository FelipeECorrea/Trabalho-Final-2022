using Repositorio.Entidades;
using Servico.ViewModels.Administrador;

namespace Servico.MapeamentoViewModels
{
    public class AdministradorViewModelMapeamentoViewModels : IAdministradorViewModelMapeamentoViewModels
    {
        public AdministradorEditarViewModel ConstruirCom(Administrador administrador) =>
            new AdministradorEditarViewModel
            {
                Id = administrador.Id,
                Nome = administrador.Nome,
                Telefone = administrador.Telefone,
                Cpf = administrador.Cpf,
                Email = administrador.Email,
            };
        private IList<AdministradorViewModel> ConstruirContatoCom(IList<Administrador> administradores)
        {
            var viewModels = new List<AdministradorViewModel>();

            foreach (var administrador in administradores)
            {
                viewModels.Add(new AdministradorViewModel
                {
                    Nome = administrador.Nome,
                    Telefone = administrador.Telefone,
                    Cpf = administrador.Cpf,
                    Email = administrador.Email,
                });
            }
            return viewModels;
        }
    }
}
