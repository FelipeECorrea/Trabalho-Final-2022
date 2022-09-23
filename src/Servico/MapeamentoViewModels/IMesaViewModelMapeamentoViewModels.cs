using Repositorio.Entidades;
using Servico.ViewModels.Mesa;

namespace Servico.MapeamentoViewModels
{
    public interface IMesaViewModelMapeamentoViewModels
    {
        MesaCadastrarViewModel ConstruirCom(Mesa mesa);
        MesaEditarViewModel AtualizarCampos(Mesa mesa);
    }
}
