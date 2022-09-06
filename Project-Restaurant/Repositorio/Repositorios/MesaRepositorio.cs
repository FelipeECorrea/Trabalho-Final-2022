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

        public Produto Cadastrar(Mesa mesa)
        {
            throw new NotImplementedException();
        }

        public void Editar(Mesa mesa)
        {
            throw new NotImplementedException();
        }

        public Produto? ObterPodId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Produto> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
