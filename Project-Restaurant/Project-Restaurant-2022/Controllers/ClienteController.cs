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
         [HttpGet("apagar")]
       

        [HttpPost("editar")]
        public IActionResult Editar([FromForm] ClienteEditarViewModel clienteEditarViewModel)
        {
            _clienteService.Editar(clienteEditarViewModel);

            return RedirectToAction("Index");
        }

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
