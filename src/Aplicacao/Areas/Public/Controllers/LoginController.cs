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
        private readonly IAdministradorService _administradorService;
        private readonly ISessao _sessao;

        public LoginController(
            IClienteService clienteService, 
            IAdministradorService administradorService, 
            ISessao sessao)
        {
            _clienteService = clienteService;
            _administradorService = administradorService;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
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

        [HttpGet("sair")]
        public IActionResult Sair()
        {
            _sessao.RemoverSessaoUsuario<Cliente>();
            _sessao.RemoverSessaoUsuario<Administrador>();

            return RedirectToAction("Index", "Home", new {Area="Public"});
        }

        [HttpPost]
        public IActionResult Entrar(LoginViewModel loginViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var usuario = _clienteService.ObterPorEmail(loginViewModel.Email);

                    if (usuario != null)
                    {
                        if (usuario.Senha == loginViewModel.Senha)
                        {
                            _sessao.CriarSessaoDoUsuario(usuario);
                            return RedirectToAction("Index", "EscolhaMesa", new { Area = "Clientes" });
                        }

                        TempData["MensageErro"] = $"senha inválida. Por favor, tente novamente.";

                        TempData["MensageErro"] = $"Usuário e/ou senha inválido(s). Por favor, tente novamente.";

                        return View("Index");
                    }
                    var admin = _administradorService.ObterPorEmail(loginViewModel.Email);

                    if (admin != null)
                    {
                        if (admin.Senha == loginViewModel.Senha)
                        {
                            _sessao.CriarSessaoDoUsuario(admin);
                            return RedirectToAction("Index", "Home", new { Area = "Admin" });
                        }

                        TempData["MensageErro"] = $"senha inválida. Por favor, tente novamente.";

                        TempData["MensageErro"] = $"Usuário e/ou senha inválido(s). Por favor, tente novamente.";

                        return View("Index");
                    }
                }
                return null;
            }
            catch (Exception erro)
            {
                TempData["MensageErro"] = $"Ops, não conseguimos realizar seu login, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
