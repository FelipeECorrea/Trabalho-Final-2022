using Repositorio.Entidades;
using Servico.ViewModels.Cliente;

namespace Servico.MapeamentoEntidades
{
    public interface IClienteMapeamentoEntidade
    {
        Cliente ConstruirCom(ClienteCadastrarViewModel viewModel, string caminho);
        void AtualizarCom(Cliente cliente, ClienteViewModel clienteViewModel, string caminho);

    }
}