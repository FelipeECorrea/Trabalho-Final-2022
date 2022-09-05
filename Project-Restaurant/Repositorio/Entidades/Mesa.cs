using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades
{
    public class Mesa : EntidadeBase
    {
        public int NumeroMesa { get; set; }
       // feature/Mapeamento-Pedido

        public IList<Cliente> Clientes { get; set; }

        public string StatusMesa { get; set; }
       // develop
    }
}
