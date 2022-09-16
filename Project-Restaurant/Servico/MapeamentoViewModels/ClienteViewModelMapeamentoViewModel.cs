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
            };
<<<<<<< HEAD
        private IList<ClienteViewModel> ConstruirContatoCom(IList<Cliente> clientes)
        {
            var viewModels = new List<ClienteViewModel>();

            foreach (var cliente in clientes)
            {
                viewModels.Add(new ClienteViewModel
                {
                    Nome = cliente.Nome,
                    Telefone = cliente.Telefone,
                    Cpf = cliente.Cpf,
                    Email = cliente.Email,
                });
            }
            return viewModels;
        }
=======
>>>>>>> 0ca1cbed1c1fe52546d13cdc0021c942e62a1eaf
    }
}
