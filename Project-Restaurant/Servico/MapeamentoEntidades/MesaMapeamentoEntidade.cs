using Repositorio.Entidades;
using Repositorio.Enums;
using Servico.ViewModels.Mesa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.MapeamentoEntidades
{
    public class MesaMapeamentoEntidade : IMesaMapeamentoEntidade
    {

        public Mesa ConstruirCom(MesaCadastrarViewModel viewModel)
        {
            return new Mesa
            {
                Status = (StatusMesa)viewModel.Status,
                NumeroMesa = viewModel.NumeroMesa
            };
        }
    }
}
