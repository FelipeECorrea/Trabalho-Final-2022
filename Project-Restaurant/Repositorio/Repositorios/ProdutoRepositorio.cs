using Microsoft.EntityFrameworkCore;
using Repositorio.BancoDados;
using Repositorio.Entidades;

namespace Repositorio.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly RestauranteContexto _contexto;

        public ProdutoRepositorio(RestauranteContexto contexto)
        {
            _contexto = contexto;
        }

        public bool Apagar(int id)
        {

            var produto = _contexto.Produtos
                .FirstOrDefault(x => x.Id == id);

            if (produto == null)
                return false;

            _contexto.Produtos.Remove(produto);
            _contexto.SaveChanges();

            return true;
        }

        public Produto Cadastrar(Produto produto)
        {
            _contexto.Produtos.Add(produto);
            _contexto.SaveChanges();

            return produto;
        }

        public void Editar(Produto produto)
        {

            _contexto.Produtos.Update(produto);
            _contexto.SaveChanges();
        }

        public Produto? ObterPorId(int Id) =>
               _contexto.Produtos.FirstOrDefault(x => x.Id == Id);



        public IList<Produto> ObterTodos() =>
        
            _contexto.Produtos.ToList();
        }
    }

