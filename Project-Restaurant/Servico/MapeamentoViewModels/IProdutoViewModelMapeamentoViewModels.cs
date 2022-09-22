using Repositorio.Entidades;
using Servico.ViewModels.Produto;

namespace Servico.MapeamentoViewModels
{
    public interface IProdutoViewModelMapeamentoViewModels
    {
        ProdutoEditarViewModel ConstruirCom(Produto produto);
    }
}
