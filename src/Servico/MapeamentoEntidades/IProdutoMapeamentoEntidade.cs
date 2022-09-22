using Repositorio.Entidades;
using Servico.ViewModels.Produto;

namespace Servico.MapeamentoEntidades
{
    public interface IProdutoMapeamentoEntidade
    {
        Produto ConstruirCom(ProdutoCadastrarViewModel viewModel, string caminho);
        Produto AtualizarCampos(Produto produto, ProdutoEditarViewModel viewModel, string caminho);
    }
}
