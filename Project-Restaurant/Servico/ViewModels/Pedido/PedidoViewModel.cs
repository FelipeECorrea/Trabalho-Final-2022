using System.ComponentModel.DataAnnotations;

namespace Servico.ViewModels.Pedido
{
    public class PedidoViewModel
    {

        [Display(Name = nameof(Cliente))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        //[MinLength(1, ErrorMessage = "{0} deve conter no mínimo {1} produto")]
        //[MaxLength(50, ErrorMessage = "{0} deve conter no máximo {1} produto")]
        public int ClienteId { get; set; }

        [Display(Name = nameof(Mesa))]
        [Required(ErrorMessage = "{0} deve conter cliente")]
        //[MinLength(1, ErrorMessage = "{0} deve conter no mínimo {1} cliente")]
        //[MaxLength(1, ErrorMessage = "{0} deve conter no máximo {1} cliente")]
        public int MesaId { get; set; }

        [Display(Name = nameof(Produto))]
        [Required(ErrorMessage = "{0} deve conter mesa")]
        //[MinLength(1, ErrorMessage = "{0} deve conter no mínimo {1} mesa")]
        //[MaxLength(1, ErrorMessage = "{0} deve conter no máximo {1} mesa")]
        public int ProdutoId { get; set; }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public int Quantidade { get; set; }

        [Display(Name = "Observacao")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public string Observacao { get; set; }
    }
}