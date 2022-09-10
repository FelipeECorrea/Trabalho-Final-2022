using Repositorio.Entidades;
using Servico.Servicos;
using Servico.ViewModels.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.MapeamentoViewModels
{
    public class ProdutoViewModelMapeamentoViewModels : IProdutoViewModelMapeamentoViewModels
    {
        public ProdutoEditarViewModel ConstruirCom(Produto produto) =>
              new ProdutoEditarViewModel
              {
                  Id = produto.Id,
                  Nome = produto.Nome,
                  Valor = produto.Valor,
                  Categoria = produto.Categoria,
                  Descricao = produto.Descricao
                  //Produtos = ConstruirContatosCom(produto.Produto),
              };
        private IList<ProdutoViewModel> ConstruirContatosCom(IList<Produto> produtos)
        {
            var viewModels = new List<ProdutoViewModel>();

            foreach (var produto in produtos)
            {
                viewModels.Add(new ProdutoViewModel
                {
                    Nome = produto.Nome,
                    Valor = produto.Valor,
                    Categoria = produto.Categoria

                });
            }
            return viewModels;
        }

    }
}

