using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.ViewModels.Mesa
{
    public class MesaCadastrarViewModel
    {
        public byte Status { get; set; }

        [Display(Name = nameof(NumeroMesa))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MinLength(1, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(6, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public int NumeroMesa { get; set; }
    }
}
