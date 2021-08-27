using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IIssueStatusRepository IssueStatus { get; }
        IIssueTypeRepository IssueType { get; }
        IJiraActionRepository JiraAction { get; }
        IJiraIssueRepository JiraIssue { get; }
        IWorkLogRepository WorkLog { get; }
        void Save();
    }
}
