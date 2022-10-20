using Repositorio.Entidades;

namespace Repositorio.Repositorios
{
    public interface IAdministradorRepositorio
    {
        Administrador ObterPorEmail(string Email);
        bool SenhaValida(string senha);
        bool Apagar(int id);
        Administrador Cadastrar(Administrador administrador);
        void Editar(Administrador administrador);
        Administrador? ObterPorId(int id);
        IList<Administrador>? ObterTodos();
        
    }
}
