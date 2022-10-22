using Aplicacao.Helpers;
using Microsoft.AspNetCore.Mvc;
using Repositorio.Entidades;
using Servico.Servicos;

namespace Aplicacao.Areas.Clientes.Controllers
{
    [Area("Clientes")]
    [Route("/client/pedido")]
    public class PedidoController : Controller
    {
        private readonly IPedidoService _pedidoService;
        private readonly ISessao _sessao;

        public PedidoController(IPedidoService pedidoService, ISessao sessao)
        {
            _pedidoService = pedidoService;
            _sessao = sessao;
        }

        [HttpGet("atual")]
        public IActionResult ObterDadosPedidoAtual()
        {
            var cliente = _sessao.BuscarSessaoDoUsuario<Cliente>();

            var dadosPedido = _pedidoService.ObterPedidoAtual(cliente.Id);

            return Ok(dadosPedido);
        }
    }
}
