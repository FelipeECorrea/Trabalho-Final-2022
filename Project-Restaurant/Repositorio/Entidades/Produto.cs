using Microsoft.Data.SqlClient.Server;
using Repositorio.Enums;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    public class Produto : EntidadeBase
    {
        public decimal Valor{ get; set; }
        //string.Format("{0:0.##}", 123,583)
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public string ProdutoCaminho { get; set; }
        public IList<ProdutoPedido> ProdutosPedidos { get; set; }
        public StatusProduto Status { get; set; }
    }
}
