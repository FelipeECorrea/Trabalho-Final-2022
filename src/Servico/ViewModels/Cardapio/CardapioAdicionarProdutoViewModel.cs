using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.ViewModels.Cardapio
{
    public class CardapioAdicionarProdutoViewModel
    {
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public int ClienteId { get; set; }
    }
}
