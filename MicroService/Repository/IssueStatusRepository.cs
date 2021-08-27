using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class IssueStatusRepository:RepositoryBase<IssueStatus>, IIssueStatusRepository
    {
        public IssueStatusRepository(RepositoryContext repositoryContext)
           : base(repositoryContext)
        {
        }
    }
}
