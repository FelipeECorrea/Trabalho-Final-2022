using Repositorio.BancoDados;
using Repositorio.Entidades;

namespace Repositorio.Repositorios
{
    internal class AdministradorRepositorio : IAdministradorRepositorio
    {
        private readonly RestauranteContexto _contexto;

        public AdministradorRepositorio(RestauranteContexto contexto)
        {
            _contexto = contexto;
        }
        public Administrador ObterPorEmail(string Email)
        {
            return _contexto.Admisitradores.FirstOrDefault(x => x.Email.ToUpper() == Email.ToUpper());
        }

        public bool SenhaValida(string senha)
        {
            Administrador administrador = new Administrador();

            return administrador.Senha == senha;
        }
        public bool Apagar(int id)
        {
            var administradorParaApagar = _contexto.Admisitradores
                .FirstOrDefault(x => x.Id == id);

            if (administradorParaApagar == null)
                return false;

            _contexto.Admisitradores.Remove(administradorParaApagar);
            _contexto.SaveChanges();

            return true;
        }

        public Administrador Cadastrar(Administrador administrador)
        {
            _contexto.Admisitradores.Add(administrador);
            _contexto.SaveChanges();

            return administrador;
        }

        public void Editar(Administrador administrador)
        {
            _contexto.Admisitradores.Update(administrador);
            _contexto.SaveChanges();
        }

        Administrador? IAdministradorRepositorio.ObterPorId(int id) =>
            _contexto.Admisitradores.FirstOrDefault(x => x.Id == id);

        public IList<Administrador> ObterTodos() =>
        _contexto.Admisitradores.ToList();
    }
}
