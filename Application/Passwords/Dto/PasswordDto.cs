using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.Passwords.Dto
{
    public class PasswordDto
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve ter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve ter entre 3 e 60 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(200, ErrorMessage = "Este campo deve ter entre 1 e 200 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo deve ter entre 1 e 200 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(200, ErrorMessage = "Este campo deve ter entre 1 e 200 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo deve ter entre 1 e 200 caracteres")]
        public string PasswordKey { get; set; }
    }
}
