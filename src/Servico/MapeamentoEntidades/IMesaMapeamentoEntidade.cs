using Repositorio.Entidades;
using Servico.ViewModels.Mesa;

namespace Servico.MapeamentoEntidades
{
    public interface IMesaMapeamentoEntidade
    {
        Mesa ConstruirCom(MesaCadastrarViewModel viewModel);
        void AtualizarCampos(Mesa mesa, MesaEditarViewModel mesaEditarViewModel);
    }
}
