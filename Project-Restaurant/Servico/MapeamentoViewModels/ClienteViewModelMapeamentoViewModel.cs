using Repositorio.Entidades;
using Servico.ViewModels.Cliente;

namespace Servico.MapeamentoViewModels
{
    public class ClienteViewModelMapeamentoViewModel : IClienteViewModelMapeamentoViewModel
    {
        public ClienteEditarViewModel ConstruirCom(Cliente cliente) =>
            new ClienteEditarViewModel
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Telefone = cliente.Telefone,
                Cpf = cliente.Cpf,
                Email = cliente.Email,
                Senha = cliente.Senha
            };
    }
}
