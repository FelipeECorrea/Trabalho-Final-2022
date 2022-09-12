using Repositorio.Entidades;
using Servico.ViewModels.Mesa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.MapeamentoViewModels
{
    public interface IMesaViewModelMapeamentoViewModels
    {
        MesaCadastrarViewModel ConstruirCom(Mesa mesa);
        MesaEditarViewModel AtualizarCampos(Mesa mesa);
    }
}
