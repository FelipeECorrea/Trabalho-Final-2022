using Aplicacao.Areas.Clientes.Views.Cardapio;
using Aplicacao.Helpers;
using Microsoft.AspNetCore.Mvc;
using Servico.Servicos;
using Servico.ViewModels.Mesa;
using Servico.ViewModels.PedidoDoCliente;

namespace Aplicacao.Areas.Clientes.Controllers
{
    [Area("Clientes")]
    [Route("client/EscolhaMesa")]
    public class EscolhaMesaController : Controller
    {
        private readonly IMesaService _mesaService;
        private readonly ISessao _sessao;

        public EscolhaMesaController(IMesaService mesaService, ISessao sessao)
        {
            _mesaService = mesaService;
            _sessao = sessao;
        }

        public ActionResult Index()
        {
            var mesas = _mesaService.ObterTodos();
            return View(mesas);
        }
        [HttpGet("listarMesas")]
        public IActionResult ListasMesas()
        {
            var selectViewModel = _mesaService.ObterTodosSelect2();
            return View(selectViewModel);
        }

        [HttpPost("abrirEscolhaMesa")]
        public IActionResult AbrirEscolhaMesa(MesaViewModel viewModel)
        {
            var escolhaMesa = new MesaViewModel();

            var cliente = _sessao.BuscarSessaoDoUsuario();
            escolhaMesa.NumeroMesa = cliente.Id;

            return View(escolhaMesa);
        }
       
    }


}
