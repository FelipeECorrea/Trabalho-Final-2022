using Repositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.MapeamentoViewModels
{
    public class MesaViewModelMapeamentoViewModels : IMesaViewModelMapeamentoViewModels
    {
        public IMesaViewModelMapeamentoViewModels ConstruirCom(Mesa mesa)
        {
            return new MesaViewModelMapeamentoViewModels
            {
                //Status = mesa.Status,
                //NumeroMesa = mesa.NumeroMesa,
            };
        }

    }
}
