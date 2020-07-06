using Entities.Utilities.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DTO.Create
{
    public class PeopleCreateDTO
    {
        public string name { get; set; }
        public TipoSexo gender { get; set; } = TipoSexo.indefinido;
        public string phone { get; set; }
        [Required(ErrorMessage = "CPF Necessario")]
        public int cpf { get; set; }
    }
}
