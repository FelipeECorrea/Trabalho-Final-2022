using Repositorio.Entidades;
using Servico.ViewModels.Cliente;

namespace Servico.MapeamentoEntidades
{
    public class ClienteMapeamentoEntidade : IClienteMapeamentoEntidade
    {
        public void AtualizarCom(Cliente cliente, ClienteViewModel clienteViewModel, string caminho)
        {

        }

        public Cliente ConstruirCom(ClienteCadastrarViewModel viewModel, string caminho) =>
            new Cliente
            {
                Nome = viewModel.Nome,
                Telefone = viewModel.Telefone,
                Cpf = viewModel.Cpf,
                Email = viewModel.Email,
                Senha = viewModel.Senha

                


            };


    }
}
