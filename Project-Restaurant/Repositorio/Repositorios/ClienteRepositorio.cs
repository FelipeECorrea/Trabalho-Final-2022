using Repositorio.BancoDados;
using Repositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Repositorios
{
    internal class ClienteRepositorio : IClienteRepositorio
    {
        private readonly RestauranteContexto _contexto;

        public ClienteRepositorio(RestauranteContexto contexto)
        {
            _contexto = contexto;
        }

        public Cliente Apagar(int id)
        {
            var clienteParaApagar = _contexto.Clientes
                .FirstOrDefault(x => x.Id == id);

            if (clienteParaApagar == null)
                return null;

            _contexto.Clientes.Remove(clienteParaApagar);
            _contexto.SaveChanges();

            return clienteParaApagar;
        }

        public Cliente Cadastrar(Cliente cliente)
        {
            _contexto.Clientes.Add(cliente);
            _contexto.SaveChanges();

            return cliente;
        }

        public void Editar(Cliente cliente)
        {
            _contexto.Clientes.Update(cliente);
            _contexto.SaveChanges();
        }

    }
}
