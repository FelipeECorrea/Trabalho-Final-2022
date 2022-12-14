using Repositorio.Entidades;
using Servico.ViewModels.Produto;

namespace Servico.MapeamentoViewModels
{
    public class ProdutoViewModelMapeamentoViewModels : IProdutoViewModelMapeamentoViewModels
    {
        public ProdutoEditarViewModel ConstruirCom(Produto produto) =>
              new ProdutoEditarViewModel
              {
                  Id = produto.Id,
                  Nome = produto.Nome,
                  Valor = (decimal)produto.Valor,
                  Categoria = produto.Categoria,
                  Descricao = produto.Descricao,
              };        
        public ProdutoIndexViewModel ConstruirProdutoIndexViewModelCom(Produto produto) =>
              new ProdutoIndexViewModel
              {
                  Id = produto.Id,
                  Nome = produto.Nome,
                  Valor = produto.Valor,
                  Imagem = produto.ProdutoCaminho,
              };

        private IList<ProdutoViewModel> ConstruirContatosCom(IList<Produto> produtos)
        {
            var viewModels = new List<ProdutoViewModel>();

            foreach (var produto in produtos)
            {
                viewModels.Add(new ProdutoViewModel
                {
                    Nome = produto.Nome,
                    Valor = (decimal)produto.Valor,
                    Categoria = produto.Categoria,
                    Descricao = produto.Descricao
                });
            }
            return viewModels;
        }

    }
}

