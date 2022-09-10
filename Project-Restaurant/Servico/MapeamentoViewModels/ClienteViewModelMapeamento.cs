using Repositorio.Entidades;
using Servico.ViewModels.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.MapeamentoViewModels
{
    internal class ClienteViewModelMapeamento : IClienteViewModelMapeamento
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
