using Repositorio.Entidades;

namespace Repositorio.Repositorios
{
    public interface IClienteRepositorio
    {
        Cliente ObterPorEmail(string Email);
        bool Apagar(int id);
        Cliente Cadastrar(Cliente cliente);
        void Editar(Cliente cliente);
        Cliente? ObterPorId(int id);
        IList<Cliente>? ObterTodos();

    }
}