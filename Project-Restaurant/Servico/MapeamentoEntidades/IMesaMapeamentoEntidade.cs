using Repositorio.Entidades;
using Servico.ViewModels.Mesa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.MapeamentoEntidades
{
    public interface IMesaMapeamentoEntidade
    {
        Mesa ConstruirCom(MesaCadastrarViewModel viewModel);
    }
}
