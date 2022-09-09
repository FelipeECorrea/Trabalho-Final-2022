using Repositorio.Entidades;
using Servico.ViewModels.Mesa;

namespace Servico.Servicos
{
    public interface IMesaService
    {
        bool Apagar(int id);
        Mesa Cadastrar(MesaCadastrarViewModel viewModel);
        Mesa? ObterPorId(int id);
        IList<Mesa> ObterTodos();
    }
}
