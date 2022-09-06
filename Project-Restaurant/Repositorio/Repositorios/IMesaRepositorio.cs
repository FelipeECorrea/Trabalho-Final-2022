using Repositorio.Entidades;

namespace Repositorio.Repositorios
{
    public interface IMesaRepositorio
    {
        bool Apagar(int id);
        Produto Cadastrar(Mesa mesa);
        void Editar(Mesa mesa);
        Produto? ObterPodId(int id);
        IList<Produto> ObterTodos();
    }
}
