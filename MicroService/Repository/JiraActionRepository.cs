using Contracts;
using Entities;
using Entities.Models;
using System;

namespace Repository
{
    class JiraActionRepository : RepositoryBase<JiraAction>, IJiraActionRepository
    {
        public JiraActionRepository(RepositoryContext repositoryContext)
          : base(repositoryContext)
        {
        }
    }
}