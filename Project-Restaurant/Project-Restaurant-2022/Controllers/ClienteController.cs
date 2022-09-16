using Microsoft.AspNetCore.Mvc;
using Repositorio.Enums;
using Servico.Servicos;
using Servico.ViewModels.Cliente;

namespace Project_Restaurant_2022.Controllers
{
    [Route("cliente")]
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public ActionResult Index()
        {
            var clientes = _clienteService.ObterTodos();

            return View(clientes);
        }

        [HttpGet("cadastrar")]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost("cadastrar")]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(ClienteCadastrarViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            _clienteService.Cadastrar(viewModel);

            return RedirectToAction("Index");
        }

        [HttpGet("editar")]
        public IActionResult Editar([FromQuery] int id)
        {
            var cliente = _clienteService.ObterPorId(id);
            var clientes = ObterCliente();

            var clienteEditarViewModel = new ClienteEditarViewModel
            {
                Nome = cliente.Nome,
                Telefone = cliente.Telefone,
                Cpf = cliente.Cpf,
                Email = cliente.Email,
            };
            ViewBag.Clientes = cliente;

            ViewBag.Clientes = cliente;

            return View(clienteEditarViewModel);
        }

        [HttpPost("editar")]
        public IActionResult Editar([FromForm] ClienteEditarViewModel clienteEditarViewModel)
        {
            if (!ModelState.IsValid)
            {
<<<<<<< HEAD
                ViewBag.Clientes = ObterCliente();
                return View(clienteEditarViewModel);
            }
=======
                return View(clienteEditarViewModel);
            }

>>>>>>> 0ca1cbed1c1fe52546d13cdc0021c942e62a1eaf
            _clienteService.Editar(clienteEditarViewModel);

            return RedirectToAction("Index");
        }

<<<<<<< HEAD
        private List<string> ObterCliente()
        {
            return Enum
               .GetNames<ClienteEmMesa>()
               .OrderBy(x => x)
               .ToList();
        }
=======
>>>>>>> 0ca1cbed1c1fe52546d13cdc0021c942e62a1eaf

        [HttpGet("obterTodosSelect2")]
        public IActionResult ObterTodosSelect2()
        {
            var selectViewModel = _clienteService.ObterPorSelect2();

            return Ok(selectViewModel);
        }


        [HttpGet("apagar")]
        public IActionResult Apagar([FromQuery] int id)
        {
            _clienteService.Apagar(id);

            return RedirectToAction("Index");
        }

    }
}
