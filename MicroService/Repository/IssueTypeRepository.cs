using Contracts;
using Entities;
using Entities.Models;
using System;
namespace Repository
{
    public class IssueTypeRepository : RepositoryBase<IssueType>, IIssueTypeRepository
    {
        public IssueTypeRepository(RepositoryContext repositoryContext)
          : base(repositoryContext)
        {
        }
    }
}
