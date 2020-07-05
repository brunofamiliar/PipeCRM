using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO
{
    public class UserDTO
    {
        public PeopleDTO name { get; set; }

        public string email { get; set; }
    }
}
