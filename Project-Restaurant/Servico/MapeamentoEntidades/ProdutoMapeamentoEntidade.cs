using Repositorio.Entidades;
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
       
        public Produto AtualizarCampos(Produto produto, ProdutoEditarViewModel viewModel)
        {
            produto.Nome = viewModel.Nome;
            produto.Valor = viewModel.Valor.GetValueOrDefault();
            produto.Categoria = viewModel.Categoria;
            produto.Descricao = viewModel.Descricao;

            return produto;
        }

        
        public Produto ConstruirCom(ProdutoCadastrarViewModel viewModel) =>
      new Produto
      {
          Nome = viewModel.Nome,
          Valor = viewModel.Valor.GetValueOrDefault(),
          Categoria = viewModel.Categoria,
          Descricao = viewModel.Descricao,
      };
    }
}
