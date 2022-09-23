using Repositorio.Entidades;
using Servico.ViewModels.Mesa;

namespace Servico.MapeamentoViewModels
{
    public class MesaViewModelMapeamentoViewModels : IMesaViewModelMapeamentoViewModels
    {
      
        public MesaCadastrarViewModel ConstruirCom(Mesa mesa) =>
             new MesaCadastrarViewModel
             {
                 NumeroMesa = mesa.NumeroMesa,
             };
        public MesaEditarViewModel AtualizarCampos(Mesa mesa) =>
             new MesaEditarViewModel
             {        
                 NumeroMesa = mesa.NumeroMesa,
             };
    }
}
