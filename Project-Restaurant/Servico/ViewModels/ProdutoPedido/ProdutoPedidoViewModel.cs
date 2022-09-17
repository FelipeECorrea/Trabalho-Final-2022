using System.ComponentModel.DataAnnotations;

namespace Servico.ViewModels.ProdutoPedido
{
    public class ProdutoPedidoViewModel
    {
        [Display(Name = nameof(Produto))]
        [Required(ErrorMessage = "deve conter um {0}")]
        public int ProdutoId { get; set; }

        [Display(Name = nameof(Pedido))]
        [Required(ErrorMessage = "deve conter um {0}")]
        public int PedidoId { get; set; }

        [Display(Name = nameof(Quantidade))]
        [Required(ErrorMessage = "deve conte uma {0}")]
        public int Quantidade { get; set; }

        [Display(Name = nameof(Valor))]
        [Required(ErrorMessage = "deve conte uma {0}")]
        public decimal Valor { get; set; }
    }
}
