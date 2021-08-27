using Contracts;
using Entities;
using Entities.Models;
using System;

namespace Repository
{
    class WorkLogRepository : RepositoryBase<WorkLog>, IWorkLogRepository
    {
        public WorkLogRepository(RepositoryContext repositoryContext)
          : base(repositoryContext)
        {
        }
    }
}
