using Repositorio.Entidades;
using Servico.ViewModels.Cliente;

namespace Servico.MapeamentoEntidades
{
    public class ClienteMapeamentoEntidade : IClienteMapeamentoEntidade
    {
<<<<<<< HEAD
        public void AtualizarCom(Cliente cliente, ClienteEditarViewModel clienteEditarViewModel)
        {
            cliente.Nome = clienteEditarViewModel.Nome;
            cliente.Telefone = clienteEditarViewModel.Telefone;
            cliente.Cpf = clienteEditarViewModel.Cpf;
            cliente.Email = clienteEditarViewModel.Email;
        }
=======
>>>>>>> 0ca1cbed1c1fe52546d13cdc0021c942e62a1eaf

        public Cliente ConstruirCom(ClienteCadastrarViewModel viewModel) =>
            new Cliente
            {
                Nome = viewModel.Nome,
                Telefone = viewModel.Telefone,
                Cpf = viewModel.Cpf,
                Email = viewModel.Email,
                Senha = viewModel.Senha
            };

        public void AtualizarCom(Cliente cliente, ClienteEditarViewModel clienteEditarViewModel)
        {
            cliente.Nome = clienteEditarViewModel.Nome;
            cliente.Telefone = clienteEditarViewModel.Telefone;
            cliente.Cpf = clienteEditarViewModel.Cpf;
            cliente.Email = clienteEditarViewModel.Email;
            cliente.Senha = clienteEditarViewModel.Senha;
        }


    }
}
