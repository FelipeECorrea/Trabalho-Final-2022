﻿using Repositorio.Entidades;
using Repositorio.Repositorios;
using Servico.MapeamentoEntidades;
using Servico.ViewModels;
using Servico.ViewModels.Pedido;

namespace Servico.Servicos
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepositorio _pedidoRepositorio;
        private readonly IPedidoMapeamentoEntidade _mapeamentoEntidade;

        public PedidoService(
             IPedidoRepositorio pedidoRepositorio,
             IPedidoMapeamentoEntidade mapeamentoEntidade,
             MapeamentoViewModels.IPedidoServiceViewModelMapeamentoViewModels _mapeamentoViewModel)
        {
            _pedidoRepositorio = pedidoRepositorio;
            _mapeamentoEntidade = mapeamentoEntidade;
        }

        public void Apagar(int id)
        {
            _pedidoRepositorio.Apagar(id);
        }

        public Pedido Cadastrar(PedidoCadastrarViewModel viewModel)
        {
            var pedido = _mapeamentoEntidade.ConstruirCom(viewModel);

            _pedidoRepositorio.Cadastrar(pedido);

            return pedido;
        }

        public Pedido ObterPorId(int id)
        {
            var BuscarPedidoPorId = _pedidoRepositorio.ObterPorId(id);

            return BuscarPedidoPorId;
        }

        public IList<Pedido> ObterTodos()
        {
            var pedidosDoBanco = _pedidoRepositorio.ObterTodos();

            return pedidosDoBanco;
        }

        public IList<SelectViewModel> ObterTodosPedidos()
        {
            var pedidos = _pedidoRepositorio.ObterTodos();

            var selectViewModel = pedidos
                .Select(x => new SelectViewModel
                {
                    Id = x.Id,
                })
                .ToList();

            return selectViewModel;
        }
    }
}
