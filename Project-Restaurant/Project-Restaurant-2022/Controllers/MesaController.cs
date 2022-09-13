using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositorio.Enums;
using Servico.Servicos;
using Servico.ViewModels.Mesa;
using Servico.ViewModels.Produto;

namespace Project_Restaurant_2022.Controllers
{
    [Route("mesa")]
    public class MesaController : Controller
    {
        private readonly IMesaService _mesaService;

        public MesaController(IMesaService mesaService)
        {
            _mesaService = mesaService;
        }

       
        public ActionResult Index()
        {
            var mesas = _mesaService.ObterTodos();
            return View(mesas);
        }

        [HttpGet("cadastrar")]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost("cadastrar")]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(MesaCadastrarViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            _mesaService.Cadastrar(viewModel);

            return RedirectToAction("Index");
        }

        [HttpGet("editar")]
        public IActionResult Editar([FromQuery] int id)
        {
            var mesa = _mesaService.ObterPorId(id);
            var mesas = ObterMesa();

            var MesaEditarViewModel = new MesaEditarViewModel
            {
                Id = mesa.Id,
                NumeroMesa = mesa.NumeroMesa
            };

            return PartialView(MesaEditarViewModel);
        }

        [HttpPost("editar")]
        public IActionResult Editar([FromForm] MesaEditarViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Mesas = ObterMesa();

                return View(viewModel);         
            }

            _mesaService.Editar(viewModel);

            return RedirectToAction("Index");
        }

        [HttpGet("obterTodosSelect2")]
        public IActionResult ObterTodosSelect2()
        {
            var selectViewModel = _mesaService.ObterTodosSelect2();

            return Ok(selectViewModel);
        }

        private List<string> ObterMesa()
        {
            return Enum
              .GetNames<StatusMesa>()
              .OrderBy(x => x)
              .ToList();
        }

        [HttpGet("apagar")]
        // http://local:host:portaapagar?id=4
        public IActionResult Apagar([FromQuery] int id)
        {
            _mesaService.Apagar(id);

            return RedirectToAction("Index");
        }
    }
}   
