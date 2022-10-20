using FluentAssertions;
using Repositorio.Entidades;
using Repositorio.Repositorios;
using Servico.MapeamentoEntidades;
using Servico.Servicos;
using Servico.ViewModels.ProdutoPedido;
using Xunit;

namespace Testes.Unit.Servico.MapeamentoEntidades
{
    public class ProdutoPedidoMapeamentoEntidadeTests
    {

        private readonly IProdutoPedidoMapeamentoEntidade _produtoPedidoMapeamentoEntidade;

        public ProdutoPedidoMapeamentoEntidadeTests()
        {
            _produtoPedidoMapeamentoEntidade = new ProdutoPedidoMapeamentoEntidade();
        }

        [Fact]
        public void Construir_Com_()
        {
            var viewModel = new ProdutoPedidoCadastrarViewModel()
            {
                PedidoId = 1,
                ProdutoId = 1,
                Quantidade = 1,
                Valor = 89.90m
            };

            var produtoPedido = _produtoPedidoMapeamentoEntidade.ConstruirCom(viewModel);

            produtoPedido.PedidoId.Should().Be(viewModel.PedidoId);
            produtoPedido.ProdutoId.Should().Be(viewModel.ProdutoId);
            produtoPedido.Quantidade.Should().Be(viewModel.Quantidade);
            produtoPedido.Valor.Should().Be(viewModel.Valor);
        }
    }
}
