using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class PeopleRepository : RepositoryBase<People>,IPeopleRepository
    {
        public PeopleRepository(RepositoryContext context):base(context)
        {

        }
    }
}
