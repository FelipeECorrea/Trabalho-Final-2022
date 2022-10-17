using Repositorio.Entidades;
using Repositorio.Enums;
using Servico.ViewModels.Produto;

namespace Servico.MapeamentoEntidades
{
    public class ProdutoMapeamentoEntidade : IProdutoMapeamentoEntidade
    {
       
        public Produto AtualizarCampos(Produto produto, ProdutoEditarViewModel produtoEditarViewModel, string caminho)
        {
            produto.Nome = produtoEditarViewModel.Nome;
            produto.Valor = (decimal)produtoEditarViewModel.Valor.GetValueOrDefault();
            produto.Categoria = produtoEditarViewModel.Categoria;
            produto.Descricao = produtoEditarViewModel.Descricao;
            produto.Status = (StatusProduto)produtoEditarViewModel.Status;

            if(!string.IsNullOrEmpty(caminho))
                produto.ProdutoCaminho = caminho;

            return produto;
        }

        public Produto ConstruirCom(ProdutoCadastrarViewModel produtoEditarViewModel, string caminho) =>
      new Produto
      {

          Nome = produtoEditarViewModel.Nome,
          Valor = (decimal)produtoEditarViewModel.Valor.GetValueOrDefault(),
          Categoria = produtoEditarViewModel.Categoria,
          Descricao = produtoEditarViewModel.Descricao,
          ProdutoCaminho = caminho,
          Status = (StatusProduto)produtoEditarViewModel.Status

      };
    }
}
