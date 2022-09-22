using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.ViewModels.PedidoDoCliente
{
    public class PedidoDoClienteCadastrarViewModel
    {
        public int ClienteId { get; set; }

        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

    }
}
