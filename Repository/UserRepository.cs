using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext context):base(context)
        {

        }
        public void CreateRanger(List<User> users)
        {
            RepositoryContext.AddRange(users.ToArray());
        }

        public User FindUserByRID(string RID)
        {
            return FindByCondition(user => user.RID.Equals(RID)).FirstOrDefault();
        }
    }
}
