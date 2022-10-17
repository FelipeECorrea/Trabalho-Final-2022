using Aplicacao.Helpers;
using System.Globalization;

namespace Aplicacao.Middlewares
{
    public class UserMiddleware
    {
        private readonly RequestDelegate _next;

        public UserMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context , ISessao sessao)
        {
            var usuarioLogado = sessao.BuscarSessaoDoUsuario();
            if (usuarioLogado != null)
            {
                context.Items.Add("UsuarioNome", usuarioLogado.Nome);
            }

            // Call the next delegate/middleware in the pipeline
            await _next(context);
        }
    }
}
