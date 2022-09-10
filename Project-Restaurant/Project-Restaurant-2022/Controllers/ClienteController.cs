using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositorio.Entidades;
using Servico.Servicos;
using Servico.ViewModels.Produto;
using Repositorio.Enums;
using Servico.ViewModels.Cliente;

namespace Project_Restaurant_2022.Controllers
{
    [Route("cliente")]
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ClienteController(IClienteService clienteService, IWebHostEnvironment webHostEnvironment)
        {
            _clienteService = clienteService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("obterTodos")]
        public IActionResult ObterTodos()
        {
            var clientes = _clienteService.ObterTodos();

            return Ok(clientes);
        }

        [HttpGet("obterPorId")]
        public IActionResult ObterPorId([FromQuery] int id)
        {
            var clientes = _clienteService.ObterPorId(id);

            return Ok(clientes);
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

            var clienteEditarViewModel = new ClienteEditarViewModel
            {
                Nome = cliente.Nome,
                Telefone = cliente.Telefone,
                Cpf = cliente.Cpf,
                Email = cliente.Email,
                Senha = cliente.Senha,

            };

            return View(clienteEditarViewModel);
        }

    }
}
