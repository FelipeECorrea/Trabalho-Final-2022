using Repositorio.Entidades;
using Repositorio.Repositorios;
using Servico.MapeamentoEntidades;
using Servico.MapeamentoViewModels;
using Servico.ViewModels;
using Servico.ViewModels.Cardapio;
using Servico.ViewModels.Mesa;
using Servico.ViewModels.Pedido;

namespace Servico.Servicos
{
    public class MesaService : IMesaService
    {
        private readonly IMesaRepositorio _mesaRepositorio;
        private readonly IMesaMapeamentoEntidade _mapeamentoEntidade;
        private readonly IMesaViewModelMapeamentoViewModels _mapeamentoViewModel;
        private readonly IPedidoService _pedidoService;
        private readonly IProdutoService _produtoService;

        public MesaService(
            IMesaRepositorio mesaRepositorio,
            IMesaMapeamentoEntidade mapeamentoEntidade,
            IMesaViewModelMapeamentoViewModels mapeamentoViewModel,
            IPedidoService pedidoService,
            IProdutoService produtoService)
        {
            _mesaRepositorio = mesaRepositorio;
            _mapeamentoEntidade = mapeamentoEntidade;
            _mapeamentoViewModel = mapeamentoViewModel;
            _pedidoService = pedidoService;
            _produtoService = produtoService;
        }

        public void AdicionarProduto(CardapioAdicionarProdutoViewModel viewModel)
        {
            var pedido = _pedidoService.ObterPorIdCliente(viewModel.ClienteId);

            if(pedido != null)
            {
                var produto = _produtoService.ObterPorId(viewModel.ProdutoId);

                var produtoPedido = new ProdutoPedido
                {
                    ProdutoId = produto.Id,
                    Quantidade = viewModel.Quantidade,
                    Valor = viewModel.Quantidade * produto.Valor
                };
                pedido.ProdutosPedidos.Add(produtoPedido);
                _pedidoService.Atualizar(pedido);
            }
        }

        public bool Apagar(int id)
        {
            return _mesaRepositorio.Apagar(id);
        }

        public Mesa Cadastrar(MesaCadastrarViewModel viewModel)
        {
            var mesa = _mapeamentoEntidade.ConstruirCom(viewModel);

            _mesaRepositorio.Cadastrar(mesa);

            return mesa;
        }

        public bool Editar(MesaEditarViewModel viewModel)
        {
            var mesa = _mesaRepositorio.ObterPorId(viewModel.Id);

            if (mesa == null)
                return false;

            _mapeamentoEntidade.AtualizarCampos(mesa, viewModel);

            _mesaRepositorio.Editar(mesa);

            return true;
        }

        public bool MesaEscolhida(int idMesa, int idUsuario)
        {
          var mesaEscolhida =  _mesaRepositorio.ObterMesaEscolhida(idMesa);
            if (mesaEscolhida == null)
            {
                return false;
            }
            var pedido = new PedidoCadastrarViewModel
            {
                ClienteId = idUsuario,
                MesaId = idMesa,
                
            };
            _pedidoService.Cadastrar(pedido);
            
            return true;
        }

        public Mesa? ObterPorId(int id) =>
            _mesaRepositorio.ObterPorId(id);

        public IList<Mesa> ObterTodos() =>
            _mesaRepositorio.ObterTodos();

        public IList<SelectViewModel> ObterTodosSelect2()
        {
            var mesas = _mesaRepositorio.ObterTodos();

            var selectViewModels = mesas
                .Select(x => new SelectViewModel
                {
                    Id = x.Id,
                    Text = x.NumeroMesa.ToString()
                })
                .ToList();

            return selectViewModels;
        }

    }


}
