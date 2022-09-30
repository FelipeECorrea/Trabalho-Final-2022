using Repositorio.Entidades;
using Servico.ViewModels;
using Servico.ViewModels.Mesa;

namespace Servico.Servicos
{
    public interface IMesaService
    {
        bool Apagar(int id);
        Mesa Cadastrar(MesaCadastrarViewModel viewModel);
        bool Editar(MesaEditarViewModel viewModel);
        Mesa? ObterPorId(int id);
        IList<Mesa> ObterTodos();
        IList<SelectViewModel> ObterTodosSelect2();
        bool MesaEscolhida(int idMesa);
    }
}
