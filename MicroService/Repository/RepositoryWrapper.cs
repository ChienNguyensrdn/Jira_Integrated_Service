using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IIssueStatusRepository _issueStatus;
        private IIssueTypeRepository _issueType;
        private IJiraActionRepository _jiraAction;
        private IJiraIssueRepository _jiraIssue;
        private IWorkLogRepository _workLog;
        private IOs_HistorystepRepository _os_Historystep;
        public IIssueStatusRepository IssueStatus
        {
            get
            {
                if (_issueStatus == null)
                {
                    _issueStatus = new IssueStatusRepository(_repoContext);
                }
                return _issueStatus;
            }
        }
        public IIssueTypeRepository IssueType
        {
            get
            {
                if (_issueType == null)
                {
                    _issueType = new IssueTypeRepository (_repoContext);
                }
                return _issueType;
            }
        }
        public IJiraActionRepository  JiraAction
        {
            get
            {
                if (_jiraAction == null)
                {
                    _jiraAction = new JiraActionRepository(_repoContext);
                }
                return _jiraAction;
            }
        }
        public IJiraIssueRepository  JiraIssue
        {
            get
            {
                if (_jiraIssue == null)
                {
                    _jiraIssue = new JiraIssueRepository(_repoContext);
                }
                return _jiraIssue;
            }
        }
        public IWorkLogRepository  WorkLog
        {
            get
            {
                if (_workLog == null)
                {
                    _workLog = new WorkLogRepository (_repoContext);
                }
                return _workLog;
            }
        }
        public IOs_HistorystepRepository Os_Historystep
        {
            get
            {
                if (_os_Historystep == null)
                {
                    _os_Historystep = new Os_HistorystepRepository(_repoContext);
                }
                return _os_Historystep;
            }
        }
        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public void Save()
        {
            _repoContext.SaveChangesAsync();
        }
    }
}
