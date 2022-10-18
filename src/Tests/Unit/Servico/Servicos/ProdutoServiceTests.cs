//using FluentAssertions;
//using NSubstitute;
//using NSubstitute.ReturnsExtensions;
//using Repositorio.Entidades;
//using Repositorio.Enums;
//using Repositorio.Repositorios;
//using Servico.MapeamentoEntidades;
//using Servico.MapeamentoViewModels;
//using Servico.Servicos;
//using Servico.ViewModels.Mesa;
//using Servico.ViewModels.Produto;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;
//using Xunit;

//namespace Testes.Unit.Servico.Servicos
//{
//    public class ProdutoServiceTests
//    {
//        private readonly IProdutoService _produtoService;
//        private readonly IProdutoRepositorio _produtoRepositorio;
//        private readonly IProdutoMapeamentoEntidade _mapeamentoEntidade;
//        private readonly IProdutoViewModelMapeamentoViewModels _mapeamentoViewModel;

//        public ProdutoServiceTests()
//        {
//            // Mock: são objetos que simulam o comportamento de objetos
//            // reais de forma controlada

//            // Mock da interface que o serviço depende
//            _produtoRepositorio = Substitute.For<IProdutoRepositorio>();
//            _mapeamentoEntidade = Substitute.For<IProdutoMapeamentoEntidade>();
//            _mapeamentoViewModel = Substitute.For<IProdutoViewModelMapeamentoViewModels>();

//            // Instancia do serviço que será testado
//            _produtoService = new ProdutoService(
//             _produtoRepositorio,_mapeamentoEntidade,_mapeamentoViewModel);
//        }
//        [Fact]
//        public void Test_Apagar()
//        {
//            // Arrange
//            var id = 10;

//            // Act
//            _produtoService.Apagar(id);

//            // Assert
//            // Validar que o método Apagar do Repositório foi chamado
//            // no método Apagar do Serviço, passando como parâmetro o id
//            _produtoRepositorio
//                .Received()
//                .Apagar(Arg.Is(10));
//        }

//        [Fact]
//        public void Test_Cadastrar()
//        {
//            // Arrange
//            var viewModel = new ProdutoCadastrarViewModel
//            {

//                Nome = "Yakissoba",
//                Categoria = "Massas",
//                Valor = 38.9m,
//                Descricao = "Massa",
//                Status = 1,

//            };

//            var produto = new Produto
//            {
//                Nome = "Yakissoba",
//                Categoria = "Massas",
//                Valor = 38.9m,
//                Descricao = "Massa",
//                Status = Repositorio.Enums.StatusProduto.Disponivel
//            };
//            var caminhoArquivos = "/oi/ta-aqui";

//            _mapeamentoEntidade
//                .ConstruirCom(
//                Arg.Is<ProdutoCadastrarViewModel>(
//                   x => x.Nome == viewModel.Nome && 
//                   x.Categoria == viewModel.Categoria && 
//                   x.Valor == viewModel.Valor && 
//                   x.Descricao == viewModel.Descricao && 
//                   x.Status == viewModel.Status),
//                Arg.Is(caminhoArquivos))
//               .Returns(produto);

//            // Act
//            _produtoService.Cadastrar(viewModel, caminhoArquivos );

//            // Assert
//            // Validar que o método Cadastrar foi chamado no serviço, passando 
//            // como parâmetro um objeto da raca com os dados do viewModel
//            _produtoRepositorio.Received(1).Cadastrar(Arg.Is<Produto>(
//                produto => ValidarProduto(produto, viewModel)));
//        }

//        [Fact]
//        public void Test_ObterPorId_Produto_Nao_Encontrado()
//        {
//            // Arrange
//            var id = 20;

//            // Mock método ObterPorId para retornar null do IRacaRepositorio
//            _produtoRepositorio
//                .ObterPorId(Arg.Is(20))
//                .ReturnsNull();

//            // Act
//            var produto = _produtoService.ObterPorId(id);

//            // Assert
//            produto.Should().BeNull();

//            _produtoRepositorio
//                .Received(1)
//                .ObterPorId(Arg.Is(20));
//        }

//        [Fact]
//        public void Test_ObterPorId_Produto_Encontrado()
//        {
//            // Arrange
//            var id = 33;

//            var produtoEsperado = new Produto
//            {
//                Id = id,
            
//            };

//            _produtoRepositorio.ObterPorId(Arg.Is(id))
//                .Returns(produtoEsperado);

//            // Act
//            var produto = _produtoService.ObterPorId(id);

//            // Assert
//            produto.Nome.Should().Be(produtoEsperado.Nome);
//            produto.Categoria.Should().Be(produtoEsperado.Categoria);
//            produto.Valor.Should().Be(produtoEsperado.Valor);
//            produto.Descricao.Should().Be(produtoEsperado.Descricao);
//        }

//        //[Fact]
//        //public void Test_Editar_Com_Produto_Encontrado()
//        //{
//        //    // Arrange
//        //    var viewModel = new ProdutoEditarViewModel
//        //    {
//        //        Id = 19,
//        //        Nome = "Yakissoba",
//        //        Valor = 39.8m,
//        //        Descricao = "Massa com molho",
//        //        Categoria = "Massas"
//        //    };

//        //    var produtoParaEditar = new Produto
//        //    {
//        //        Id = 19,
//        //        Nome = "Yakissoba",
//        //        Valor = 39.6m,
//        //        Descricao = "Massa com molho }II",
//        //        Categoria = "Massas"
//        //    };

//        //    _produtoRepositorio
//        //        .ObterPorId(Arg.Is(viewModel.Id))
//        //        .Returns(produtoParaEditar);

//        //    // Act
//        //    _produtoService.Editar(viewModel);

//        //}

//        //[Fact]
//        //public void Test_Editar_Sem_Produto_Encontrado()
//        //{
//        //    // Arrange
//        //    var viewModel = new ProdutoEditarViewModel
//        //    {
//        //        Id = 1,
//        //        Categoria = nameof(StatusProduto.Disponivel),
//        //        Nome = "Yakissoba",
//        //        Valor = 3.9m,
//        //        Descricao = "Massa"
//        //    };

//        //    _produtoRepositorio
//        //        .ObterPorId(Arg.Is(viewModel.Id))
//        //        .ReturnsNull();

//        //    // Act
//        //    _produtoService.Editar(viewModel);

//        //}

//        private bool ValidarProduto(Produto produto, ProdutoCadastrarViewModel viewModel)
//        {
//            produto.Nome.Should().Be(viewModel.Nome);
//            produto.Categoria.Should().Be(viewModel.Categoria);
//            produto.Valor.Should().Be(viewModel.Valor);
//            produto.Descricao.Should().Be(viewModel.Descricao);
//            produto.Status.Should().Be((StatusProduto)viewModel.Status);

//            return true;
//        }

//        private bool ValidarProdutoEditarViewModel(
//            Produto produto,
//            ProdutoEditarViewModel viewModel)
//        {
//            produto.Categoria.Should().Be(viewModel.Categoria);
//            produto.Nome.Should().Be(viewModel.Nome.Trim());
//            produto.Valor.Should().Be(viewModel.Valor);
//            produto.Descricao.Should().Be(viewModel.Descricao.Trim());
//            produto.Status.Should().Be((StatusProduto)viewModel.Status);

//            return true;
//        }
//    }
//}


