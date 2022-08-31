using Repositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public Produto Cadastrar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void Editar(Produto produto)
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
