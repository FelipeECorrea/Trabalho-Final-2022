using Repositorio.Entidades;

namespace Servico.Servicos
{
    public interface IMesaService
    {
        Mesa? ObterPorId(int id);
        IList<Mesa> ObterTodos();
    }
}
