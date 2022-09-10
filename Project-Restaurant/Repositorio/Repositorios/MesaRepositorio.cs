using Repositorio.BancoDados;
using Repositorio.Entidades;

namespace Repositorio.Repositorios
{
    public class MesaRepositorio : IMesaRepositorio
    {
        private readonly RestauranteContexto _contexto;

        public MesaRepositorio(RestauranteContexto contexto)
        {
            _contexto = contexto;
        }

        public bool Apagar(int id)
        {

            var mesa = _contexto.Mesas
                .FirstOrDefault(x => x.Id == id);

            if ( mesa == null)
                return false;

            _contexto.Mesas.Remove(mesa);
            _contexto.SaveChanges();

            return true;
        }

        public Mesa Cadastrar(Mesa mesa)
        {

            _contexto.Mesas.Add(mesa);
            _contexto.SaveChanges();

            return mesa;
        }

        public void Editar(Mesa mesa)
        {
            _contexto.Mesas.Update(mesa);
            _contexto.SaveChanges();
        }

        public Mesa? ObterPorId(int id)
        {
            var mesa = _contexto.Mesas.Where(x => x.Id == id).FirstOrDefault();

            return mesa;
        }

        public IList<Mesa> ObterTodos()
        {
            var mesas = _contexto.Mesas.ToList();

            return mesas;
        }
    }
}
