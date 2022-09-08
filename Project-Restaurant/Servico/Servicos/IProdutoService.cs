using Repositorio.Entidades;
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
        Produto Cadastrar(ProdutoCadastrarViewModel viewModel);
        bool Editar(ProdutoEditarViewModel viewModel);
        ProdutoEditarViewModel? ObterPorId(int id);
        IList<Produto> ObterTodos();
        IList<SelectViewModel> ObterTodosSelect2();
    }
}

