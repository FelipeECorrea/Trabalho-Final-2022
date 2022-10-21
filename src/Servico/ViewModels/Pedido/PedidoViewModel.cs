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

        [Display(Name = nameof(Observacao))]
        public string Observacao { get; set; }

    }
}