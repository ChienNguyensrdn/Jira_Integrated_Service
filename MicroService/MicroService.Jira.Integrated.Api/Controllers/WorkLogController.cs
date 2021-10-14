using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroService.Jira.Integrated.Api.Controllers
{
    [Route("api/work-log")]
    [ApiController]
    public class WorkLogController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;
        public WorkLogController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
            //os_historystep
            //jiraissue WORKFLOW_ID ref os_historystep [ENTRY_ID]

            //os_historystep [STEP_ID] ref issuestatus [id]
        }
        [Route("history/fromDate/{fromDate}/toDate/{toDate}/project{projectId}")]
        [HttpGet]
        public async Task<List<Os_Historystep>> GetWorkLogHistory(string fromDate,string toDate, decimal projectId=-1)
        {
            try
            {
                var outDate = fromDate.Split('-');
                DateTime? _fromDate = new DateTime(int.Parse(outDate[0]), int.Parse(outDate[1]), int.Parse(outDate[2]));
                outDate = toDate.Split('-');
                DateTime? _toDate = new DateTime(int.Parse(outDate[0]), int.Parse(outDate[1]), int.Parse(outDate[2]));
                var WorkFlowIds = await Task.FromResult( _repoWrapper.JiraIssue.FindByCondition(x => (x.Project == projectId || projectId == -1)
                && x.resolutionDate >= _fromDate && x.resolutionDate <= _toDate
                ).Select(x=>x.WorkFlow_Id).ToList());
                var WorkLogHistorys = await Task.FromResult(
                    _repoWrapper.Os_Historystep.FindByCondition(x => WorkFlowIds.Contains(x.EntryId)).ToList());
                return WorkLogHistorys;
            }
            catch (Exception)
            {
                return new List<Os_Historystep>();
            }
        }


    }
}
