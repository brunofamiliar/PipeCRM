using Entities.Models.Commons;
using Entities.Utilities.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class People : BaseModel
    {

        public string name { get; set; }
        public TipoSexo gender { get; set; } = TipoSexo.indefinido;
        public string phone { get; set; }
        [Required(ErrorMessage ="Cpf é necessario")]
        public int cpf { get; set; }
    }
}
