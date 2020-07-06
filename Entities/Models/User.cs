using Entities.Models.Commons;
using Entities.Utilities.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class User : BaseModel
    {
        [Required(ErrorMessage = "E-mail obrigatório")]
        public string email { get; set; }
        [Required(ErrorMessage = "Senha Obrigatória")]
        [MaxLength(15)]
        public string senha { get; set; }
        public TipoUsuario tipoUsuario { get; set; } = TipoUsuario.cliente;
        [ForeignKey(nameof(People))]
        public int? peopleId { get; set; }
        public People People { get; set; }
    }
}
