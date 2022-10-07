using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidade
{
    // Entidades: são representações das tabelas para classe de objetos
    public class Produto
    {
        public int Id { get; set; }

        public decimal Valor { get; set; }

        public string Nome { get; set; }

        public string categoria { get; set; }

        public string descricao { get; set; }

    }
}
