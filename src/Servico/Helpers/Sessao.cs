using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Repositorio.Entidades;

namespace Aplicacao.Helpers
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _httpContext;

        public Sessao(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        private const string SessionKeyAdmnistrador = "administradorSession";
        private const string SessionKeyCliente = "clienteSession";
        private const string SessionKeySupplier = "supplierSession";

        public TEntidade? BuscarSessaoDoUsuario<TEntidade>() where TEntidade : Usuario
        {
            var sessionKey = GetSessionKey<TEntidade>();

            var session = GetSession().GetString(sessionKey);

            if (string.IsNullOrEmpty(session))
                return default;

            return JsonConvert.DeserializeObject<TEntidade>(session);
        }

        public void CriarSessaoDoUsuario<TEntidade>(TEntidade entidadeBase) where TEntidade : Usuario
        {
            var userBaseString = JsonConvert.SerializeObject(entidadeBase);

            var sessionKey = GetSessionKey<TEntidade>();

            GetSession().SetString(sessionKey, userBaseString);
        }

        public void RemoverSessaoUsuario<TEntidade>() where TEntidade : Usuario
        {
            var sessionKey = GetSessionKey<TEntidade>();

            GetSession().Remove(sessionKey);
        }

        private string GetSessionKey<TEntidade>() where TEntidade : Usuario
        {
            var tipo = typeof(TEntidade);

            if (tipo == typeof(Administrador))
                return SessionKeyAdmnistrador;

            if (tipo == typeof(Cliente))
                return SessionKeyCliente;

            return SessionKeySupplier;

        }

        private ISession GetSession() =>
            _httpContext.HttpContext.Session;
    }
}
