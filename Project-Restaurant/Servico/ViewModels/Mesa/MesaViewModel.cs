﻿using System.ComponentModel.DataAnnotations;

namespace Servico.ViewModels.Mesa
{
    public class MesaViewModel
    {
        public byte Status { get; set; }

        [Display(Name = nameof(NumeroMesa))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MinLength(1, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(3, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public int NumeroMesa { get; set; }
    }
}
