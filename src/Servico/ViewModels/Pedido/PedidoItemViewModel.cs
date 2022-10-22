using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.ViewModels.Pedido
{
    public class PedidoItemViewModel
    {
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }
}
