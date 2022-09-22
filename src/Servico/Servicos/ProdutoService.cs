using Repositorio.Entidades;
using Repositorio.Repositorios;
using Servico.Helpers;
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
        private const string PastaImagens = "pets";

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

        public Produto Cadastrar(ProdutoCadastrarViewModel viewModel, string caminhoArquivos)
        {

            var caminho = SalvarArquivo(viewModel, caminhoArquivos);
            var produto = _mapeamentoEntidade.ConstruirCom(viewModel, caminho);

            _produtoRepositorio.Cadastrar(produto);

            return produto;

        }

        public bool Editar(ProdutoEditarViewModel viewModel, string caminhoArquivos)
        {
            var produto = _produtoRepositorio.ObterPorId(viewModel.Id);
            
            if (produto == null)
                return false;

            var caminho = SalvarArquivo(viewModel, caminhoArquivos, produto.ProdutoCaminho);

            _mapeamentoEntidade.AtualizarCampos(produto, viewModel, caminho);

            _produtoRepositorio.Editar(produto);

            return true;
        }

        private string SalvarArquivo(ProdutoViewModel viewModel, string caminhoArquivos, string? arquivoAntigo = "")
        {
            if (viewModel.Arquivo == null)
                return string.Empty;

            var caminhoPastaImagens = Path.Combine(caminhoArquivos, ArquivoHelper.ObterCaminhoPastas());

            if (!Directory.Exists(caminhoPastaImagens))
                Directory.CreateDirectory(caminhoPastaImagens);

            if (!string.IsNullOrEmpty(arquivoAntigo))
                ApagarArquivoAntigo(caminhoPastaImagens, arquivoAntigo);

            var informacaoDoArquivo = new FileInfo(viewModel.Arquivo.FileName);
            var nomeArquivo = Guid.NewGuid() + informacaoDoArquivo.Extension;

            var caminhoArquivo = Path.Combine(caminhoPastaImagens, nomeArquivo);

            using (var stream = new FileStream(caminhoArquivo, FileMode.Create))
            {
                viewModel.Arquivo.CopyTo(stream);

                return nomeArquivo;
            }
        }

        private void ApagarArquivoAntigo(string caminhoPastaImagens, string arquivoAntigo)
        {
            var caminhoArquivoAntigo = Path.Join(caminhoPastaImagens, arquivoAntigo);

            if (File.Exists(caminhoArquivoAntigo))
                File.Delete(caminhoArquivoAntigo);
        }

        public ProdutoEditarViewModel? ObterPorId(int id)
        {
            var produto = _produtoRepositorio.ObterPorId(id);

            if (produto == null)
                return null;

            var viewModel = _mapeamentoViewModel.ConstruirCom(produto);

            return viewModel;
        }

        public IList<Produto> ObterTodos() =>

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

