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
                  Valor = produto.Valor,
                  Categoria = produto.Categoria,
                  Descricao = produto.Descricao,
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
                    Categoria = produto.Categoria,
                    Descricao = produto.Descricao
                });
            }
            return viewModels;
        }

    }
}

