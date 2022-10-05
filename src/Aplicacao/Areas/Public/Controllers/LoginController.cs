using Microsoft.AspNetCore.Mvc;
using Aplicacao.Helpers;
using Repositorio.Entidades;
using Servico.Servicos;
using Servico.ViewModels.Login;
using Servico.ViewModels.Cliente;
using Repositorio.Enums;

namespace Aplicacao.Areas.Public.Controllers
{
    [Area("Public")]
    [Route("/login")]
    public class LoginController : Controller
    {
        private readonly IClienteService _clienteService;
        private readonly ISessao _sessao;

        public LoginController(IClienteService clienteService, ISessao sessao)
        {
            _clienteService = clienteService;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            if (_sessao.BuscarSessaoDoUsuario() != null) 
                return RedirectToAction("Index", "Home");

            return View();
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

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Entrar(LoginViewModel loginViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Cliente cliente = _clienteService.ObterPorEmail(loginViewModel.Email);

                    if (cliente != null)
                    {
                        if (cliente.Senha == loginViewModel.Senha)
                        {
                            _sessao.CriarSessaoDoUsuario(cliente);
                            return RedirectToAction("Index", "Home");
                        }

                        TempData["MensageErro"] = $"senha inválida. Por favor, tente novamente.";
                    }

                    TempData["MensageErro"] = $"Usuário e/ou senha inválido(s). Por favor, tente novamente.";
                }
                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensageErro"] = $"Ops, não conseguimos realizar seu login, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
