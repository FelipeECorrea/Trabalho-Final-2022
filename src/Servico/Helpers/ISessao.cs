using Repositorio.Entidades;

namespace Aplicacao.Helpers
{
    public interface ISessao
    {
        void CriarSessaoDoUsuario<TEntidade>(TEntidade entidadeBase) where TEntidade : Usuario;
        void RemoverSessaoUsuario<TEntidade>() where;
        Cliente BuscarSessaoDoUsuario();
    }
}
