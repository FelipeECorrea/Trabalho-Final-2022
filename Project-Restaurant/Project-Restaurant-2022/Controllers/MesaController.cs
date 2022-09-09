using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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


    }   
}   
