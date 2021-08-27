using Contracts;
using Entities;
using Entities.Models;
using System;

namespace Repository
{
    public class JiraIssueRepository: RepositoryBase<Jiraissue>, IJiraIssueRepository 
    {
        public JiraIssueRepository(RepositoryContext repositoryContext)
          : base(repositoryContext)
        {
        }
    }
}
