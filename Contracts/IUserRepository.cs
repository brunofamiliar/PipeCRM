using Contracts.Base;
using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        User FindUserByRID(string RID);
        void CreateRanger(List<User> users);
    }
}
