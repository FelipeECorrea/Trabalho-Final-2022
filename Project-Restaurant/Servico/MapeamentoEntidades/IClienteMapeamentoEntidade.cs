using Repositorio.Entidades;
using Servico.ViewModels.Cliente;

namespace Servico.MapeamentoEntidades
{
    public interface IClienteMapeamentoEntidade
    {
        Cliente ConstruirCom(ClienteCadastrarViewModel viewModel);
        void AtualizarCom(Cliente cliente, ClienteEditarViewModel clienteEditarViewModel);

    }
}