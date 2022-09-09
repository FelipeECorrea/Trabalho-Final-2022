using Repositorio.Entidades;
using Repositorio.Repositorios;
using Servico.MapeamentoEntidades;
using Servico.MapeamentoViewModels;
using Servico.ViewModels;
using Servico.ViewModels.Produto;

namespace Servico.Servicos
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        private readonly IProdutoMapeamentoEntidade _mapeamentoEntidade;
        private readonly IProdutoViewModelMapeamentoViewModels _mapeamentoViewModel;


        public ProdutoService(
            IProdutoRepositorio produtoRepositorio,
            IProdutoMapeamentoEntidade mapeamentoEntidade,
            IProdutoViewModelMapeamentoViewModels mapeamentoViewModel)
        {
            _produtoRepositorio = produtoRepositorio;
            _mapeamentoEntidade = mapeamentoEntidade;
            _mapeamentoViewModel = mapeamentoViewModel;
        }

        public bool Apagar(int id)
        {
            return _produtoRepositorio.Apagar(id);
        }

        public Produto Cadastrar(ProdutoCadastrarViewModel viewModel)
        {
            var produto = _mapeamentoEntidade.ConstruirCom(viewModel);

            _produtoRepositorio.Cadastrar(produto);

            return produto;
        }

        public bool Editar(ProdutoEditarViewModel viewModel)
        {
            var produto = _produtoRepositorio.ObterPorId(viewModel.Id);

            if (produto == null)
                return false;

            produto = _mapeamentoEntidade.AtualizarCampos(produto, viewModel);

            _produtoRepositorio.Editar(produto);

            return true;
        }

        public ProdutoEditarViewModel? ObterPorId(int id)
        {
            var produto = _produtoRepositorio.ObterPorId(id);

            if (produto == null)
                return null;

            var viewModel = _mapeamentoViewModel.ConstruirCom(produto);

            return viewModel;
        }

        public IList<Produto> ObterTodos()=>
        
            _produtoRepositorio.ObterTodos();
        

        public IList<SelectViewModel> ObterTodosSelect2()
        {
            var produtos = _produtoRepositorio.ObterTodos();

            var selectViewModels = produtos
                .Select(x => new SelectViewModel
                {
                    Id = x.Id,
                    Text = x.Nome
                })
                .ToList();

            return selectViewModels;
        }
    }
}

