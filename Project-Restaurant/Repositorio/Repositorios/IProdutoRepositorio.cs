using Repositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Repositorios
{
    public interface IProdutoRepositorio
    {
        bool Apagar(int id);
        Produto Cadastrar(Produto produto);
        void Editar(Produto produto);
        Produto? ObterPodId(int id);
        IList<Produto> ObterTodos();
    }
}
