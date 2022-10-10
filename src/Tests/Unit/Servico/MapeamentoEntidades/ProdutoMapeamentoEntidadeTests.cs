using FluentAssertions;
using Repositorio.Entidades;
using Servico.MapeamentoEntidades;
using Servico.ViewModels.Produto;
using Xunit;

namespace Testes.Unit.Servico.MapeamentoEntidades
{
    public class ProdutoMapeamentoEntidadeTests
    {

        private readonly IProdutoMapeamentoEntidade _produtoMapeamentoEntidade;

        public ProdutoMapeamentoEntidadeTests()
        {
            _produtoMapeamentoEntidade = new ProdutoMapeamentoEntidade();
        }
    }
}

//[Fact]
//public void Test_ConstruirCom()
//{
//    // Arrange
//    var viewModel = new ProdutoCadastrarViewModel
//    {
//        Nome = "Felipe",
//        Valor = 30,
//        Categoria = "Massas",
//        Descricao = "Massa com molho",
//        Status = 1,
//        Arquivo = "fav.ico"
//    };

//    // Act
//    _produtoMapeamentoEntidade.ConstruirCom(ProdutoCadastrarViewModel viewModel);

//    // Assert
//    viewModel.Nome.Should().Be(viewModel.Nome);
//    viewModel.Valor.Should().Be(viewModel.Valor);
//    viewModel.Categoria.Should().Be(viewModel.Categoria);
//    viewModel.Descricao.Should().Be(viewModel.Descricao);
//    viewModel.Status.Should().Be(viewModel.Status);
//    viewModel.Arquivo.Should().Be(viewModel.Arquivo);

//}

//[Fact]
//public void Test_AtualizarCampos()
//{
//    // Arrange
//    var produto = new Produto
//    {
//        Nome = "Felipe",
//        Valor = 30.00m,
//        Categoria = "Massas",
//        Descricao = "Massa com molho",
//        Status = Repositorio.Enums.StatusProduto.Disponivel,
//        Arquivo = "fav.ico"
//    };

//var viewModelEditar = new ProdutoEditarViewModel
//{
//    Nome = "Felipe",
//    Valor = 30.00m,
//    Categoria = "Massas",
//    Descricao = "Massa com molho",
//    Status = 1,
//    Arquivo = "fav.ico"
//};

//// Act
//_produtoMapeamentoEntidade.AtualizarCampos(Produto produto, ProdutoEditarViewModel viewModel, string caminho); ;

//// Assert
//produto.Valor.Should().Be(viewModelEditar.Valor);
//produto.Nome.Should().Be(viewModelEditar.Nome);
//produto.Categoria.Should().Be(viewModelEditar.Categoria);
//produto.Descricao.Should().Be(viewModelEditar.Descricao);

//}

//}
//}