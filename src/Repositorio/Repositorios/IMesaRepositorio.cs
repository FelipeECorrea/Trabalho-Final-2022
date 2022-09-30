using Repositorio.Entidades;

namespace Repositorio.Repositorios
{
    public interface IMesaRepositorio
    {
        bool Apagar(int id);
        Mesa Cadastrar(Mesa mesa);
        void Editar(Mesa mesa);
        Mesa? ObterPorId(int id);
        IList<Mesa> ObterTodos();
        Mesa? ObterMesaDesocupadaPorId(int id);
    }
}
