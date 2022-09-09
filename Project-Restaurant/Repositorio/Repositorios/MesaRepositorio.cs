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
            throw new NotImplementedException();
        }

        public Mesa Cadastrar(Mesa mesa)
        {
            throw new NotImplementedException();
        }

        public void Editar(Mesa mesa)
        {
            throw new NotImplementedException();
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
