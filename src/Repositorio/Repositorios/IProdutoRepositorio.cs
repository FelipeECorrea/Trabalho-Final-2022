using Repositorio.Entidades;

namespace Repositorio.Repositorios
{
    public interface IProdutoRepositorio
    {
        bool Apagar(int Id);
        Produto Cadastrar(Produto produto);
        void Editar(Produto produto);
        Produto? ObterPorId(int Id);
        IList<Produto> ObterTodos();
    }
}
