using Repositorio.Entidades;
using Servico.ViewModels;
using Servico.ViewModels.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.Servicos
{
    public interface IProdutoService
    {
        bool Apagar(int id);
        Produto Cadastrar(ProdutoCadastrarViewModel viewModel, string caminhoArquivos);
        bool Editar(ProdutoEditarViewModel viewModel, string caminhoArquivos);
        ProdutoEditarViewModel? ObterPorId(int id);
        IList<Produto> ObterTodos();
        IList<SelectViewModel> ObterTodosSelect2();
    }
}

