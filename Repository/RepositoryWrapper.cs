using Contracts;
using Entities;
using System;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {

        private RepositoryContext _repositoryContext;
        public IUserRepositoy userRepositoy => throw new NotImplementedException();

        public void Save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}
