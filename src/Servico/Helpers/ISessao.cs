using Repositorio.Entidades;

namespace Aplicacao.Helpers
{
    public interface ISessao
    {
        void CriarSessaoDoUsuario(Cliente cliente);
        void RemoverSessaoUsuario();
        Cliente BuscarSessaoDoUsuario();
    }
}
