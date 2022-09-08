using Repositorio.Entidades;

namespace Repositorio.Repositorios
{
    public interface IClienteRepositorio
    {
        Cliente Cadastrar(Cliente cliente);
        Cliente Apagar(int Id);
        void Editar(Cliente cliente);

    }
}