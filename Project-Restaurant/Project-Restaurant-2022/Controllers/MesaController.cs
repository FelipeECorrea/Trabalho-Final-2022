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
            var viewModel = _mesaService.ObterPorId(id);

            return PartialView(viewModel);
        }

        [HttpPost("editar")]
        public IActionResult Editar([FromForm] MesaEditarViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return PartialView(viewModel);
            }

            var mesa = _mesaService.Editar(viewModel);

            return RedirectToAction(nameof(Editar), new { id = viewModel.Id });
        }

        private object ObterMesa()
        {
            return Enum
              .GetNames<StatusMesa>()
              .OrderBy(x => x)
              .ToList();
        }

    }
}   
