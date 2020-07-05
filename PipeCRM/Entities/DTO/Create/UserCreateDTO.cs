﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DTO.Create
{
   public class UserCreateDTO
    {
        public PeopleCreateDTO people { get; set; }
        [Required(ErrorMessage = "Email Obrigatório!")]
        public string email { get; set; }
        [Required(ErrorMessage = "Senha Obrigatório!")]
        public string password { get; set; }
    }
}
