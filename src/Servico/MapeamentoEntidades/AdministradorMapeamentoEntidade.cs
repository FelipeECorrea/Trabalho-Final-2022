using Repositorio.Entidades;
using Servico.ViewModels.Administrador;
using Servico.ViewModels.Cliente;

namespace Servico.MapeamentoEntidades
{
    public class AdministradorMapeamentoEntidade : IAdministradorMapeamentoEntidade
    {
        public void AtualizarCom(Administrador administrador, AdministradorEditarViewModel administradorEditarViewModel)
        {
            administrador.Nome = administradorEditarViewModel.Nome;
            administrador.Telefone = administradorEditarViewModel.Telefone;
            administrador.Cpf = administradorEditarViewModel.Cpf;
            administrador.Email = administradorEditarViewModel.Email;
        }

        public Administrador ConstruirCom(AdministradorCadastrarViewModel viewModel) =>
            new Administrador
            {
                Nome = viewModel.Nome,
                Telefone = viewModel.Telefone,
                Cpf = viewModel.Cpf,
                Email = viewModel.Email,
                Senha = viewModel.Senha
            };
    }
}
