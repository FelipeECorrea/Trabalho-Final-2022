using Repositorio.Entidades;
using Servico.ViewModels.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.MapeamentoEntidades
{
    public interface IProdutoMapeamentoEntidade
    {
        Produto ConstruirCom(ProdutoCadastrarViewModel viewModel);
        Produto AtualizarCampos(Produto produto, ProdutoEditarViewModel viewModel);
    }
}
