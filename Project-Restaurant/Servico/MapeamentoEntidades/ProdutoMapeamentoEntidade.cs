using Repositorio.Entidades;
using Repositorio.Enums;
using Servico.ViewModels.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.MapeamentoEntidades
{
    public class ProdutoMapeamentoEntidade : IProdutoMapeamentoEntidade
    {
       
        public Produto AtualizarCampos(Produto produto, ProdutoEditarViewModel produtoEditarViewModel)
        {
            produto.Nome = produtoEditarViewModel.Nome;
            produto.Valor = produtoEditarViewModel.Valor.GetValueOrDefault();
            produto.Categoria = produtoEditarViewModel.Categoria;
            produto.Descricao = produtoEditarViewModel.Descricao;
            produto.Status = (StatusProduto)produtoEditarViewModel.Status;

            return produto;
        }

        public Produto ConstruirCom(ProdutoCadastrarViewModel produtoEditarViewModel) =>
      new Produto
      {
          Nome = produtoEditarViewModel.Nome,
          Valor = produtoEditarViewModel.Valor.GetValueOrDefault(),
          Categoria = produtoEditarViewModel.Categoria,
          Descricao = produtoEditarViewModel.Descricao,
          ProdutoCaminho = produtoEditarViewModel.Arquivo.ToString(),
          Status = (StatusProduto)produtoEditarViewModel.Status




      };
    }
}
