﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.DTO.User
{
    public class CreateUserDTO
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo de Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email em formato invalido")]
        public string Email { get; set; }
    }
}
