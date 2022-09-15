using Microsoft.AspNetCore.Mvc;
using Repositorio.Entidades;
using Repositorio.Repositorios;
using Servico.ViewModels.Login;

namespace Project_Restaurant_2022.Controllers
{
    public class LoginController : Controller
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public LoginController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginViewModel loginViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Cliente cliente = _clienteRepositorio.ObterPorEmail(loginViewModel.Email);
                    var senhaCliente = _clienteRepositorio;

                    if (cliente != null)
                    {
                        if (senhaCliente.SenhaValida(loginViewModel.Senha))
                        {
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
