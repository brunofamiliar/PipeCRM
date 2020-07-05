using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IUserRepositoy userRepositoy { get; }

        void Save();
    }
}
