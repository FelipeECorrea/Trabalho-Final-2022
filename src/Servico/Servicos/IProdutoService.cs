using Repositorio.Entidades;
using Servico.ViewModels;
using Servico.ViewModels.Produto;

namespace Servico.Servicos
{
    public interface IProdutoService
    {
        bool Apagar(int id);
        Produto Cadastrar(ProdutoCadastrarViewModel viewModel, string caminhoArquivos);
        bool Editar(ProdutoEditarViewModel viewModel, string caminhoArquivos);
        ProdutoEditarViewModel? ObterPorId(int id);
        ProdutoIndexViewModel? ObterPorIdParaIndex(int id);
        IList<Produto> ObterTodos();
        IList<SelectViewModel> ObterTodosSelect2();
        bool ProdutoEscolhido(int idProduto);
    }
}

