using Repositorio.Entidades;
using Servico.ViewModels.Mesa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.MapeamentoViewModels
{
    public class MesaViewModelMapeamentoViewModels /*:*/ /*IMesaViewModelMapeamentoViewModels*/
    {
      
        public MesaCadastrarViewModel ConstruirCom(Mesa mesa) =>
             new MesaCadastrarViewModel
             {
                 NumeroMesa = mesa.NumeroMesa,

             }; 

    }
}
