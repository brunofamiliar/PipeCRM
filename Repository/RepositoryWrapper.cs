using Contracts;
using Entities;
using Entities.Models;
using System;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {

        private RepositoryContext _repositoryContext;
        private IUserRepository userRepository;

        public IUserRepository UserRepository { get 
            { if (userRepository == null) 
                {
                    userRepository = new UserRepository(_repositoryContext);
                }
                return userRepository; 
            } }

        IUserRepository IRepositoryWrapper.userRepository => throw new NotImplementedException();

        public void Save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}
