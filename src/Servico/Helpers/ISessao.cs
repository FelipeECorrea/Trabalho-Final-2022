using Repositorio.Entidades;

namespace Aplicacao.Helpers
{
    public interface ISessao
    {
        void CriarSessaoDoUsuario<TEntidade>(TEntidade entidadeBase) where TEntidade : Usuario;
        void RemoverSessaoUsuario<TEntidade>() where TEntidade : Usuario;
        TEntidade BuscarSessaoDoUsuario<TEntidade>() where TEntidade : Usuario;
    }
}
