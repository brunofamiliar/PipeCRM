using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models.Commons
{
    public class BaseModel
    {
        public int Id { get; set; }
        public string RID { get; set; } = Utilities.Randonizer.GenerateRID(25);
        public DateTime Registro { get; set; } = DateTime.UtcNow;

    }
}
