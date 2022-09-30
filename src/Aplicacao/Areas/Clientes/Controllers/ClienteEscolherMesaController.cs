using Aplicacao.Helpers;
using Microsoft.AspNetCore.Mvc;
using Servico.Servicos;

namespace Aplicacao.Areas.Clientes.Controllers
{
    public class ClienteEscolherMesaController : Controller
    {
        private readonly MesaService _mesaService;
        private readonly ClienteService _clienteService;
        private readonly ProdutoService _ProdutoService;
        private readonly ISessao _sessao;
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListarMesas(int IdClienteSessao)
        {
            var idCliente = _clienteService.ObterPorId(IdClienteSessao);
            if (idCliente == null)
            {
                return View(Index);
            }
            var mesas = _mesaService.ObterTodosSelect2();
            return View(mesas);
        }

        [HttpPost]
        public IActionResult EscolhaDeMesa(int idMesa)
        {
            var idclienteSessao = _sessao.BuscarSessaoDoUsuario().Id;
            var mesaId = _mesaService.MesaEscolhida(idMesa);


            return View();
        }

    }
}
