using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroService.Jira.Integrated.Api.Controllers
{
    [ApiController]
    [Route("api/jira-issues")]
    public class JiraissueController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;
        public JiraissueController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        [Route("project/{projectId}/pKey/{pKey}/page/{page}/pageSize/{pageSize}")]
        [HttpGet]
        public async Task<List <Jiraissue>> Get(decimal projectId,string pKey="FULL",int page=1, int pageSize=10)
        {
            var jiraissues = _repoWrapper.JiraIssue.FindByCondition(x => x.Project==projectId &&(x.pkey==pKey || pKey=="FULL"))
                .OrderByDescending(x=>x.Created ).Skip(page * pageSize).Take(pageSize);
            return await Task.FromResult(jiraissues.ToList()); 
        }
        [HttpPut("{Id}")]
        public async Task<IActionResult>updateJiraIssue(decimal Id, decimal timeSpent)
        {
            var jiraissue = await Task.FromResult( _repoWrapper.JiraIssue.FindByCondition(x => x.Id == Id).FirstOrDefault());
            if (jiraissue == null)
                return NotFound();
            jiraissue.timeSpent = timeSpent;
            try
            {
               _repoWrapper.JiraIssue.Update(jiraissue);
               _repoWrapper.Save();
            }
            catch(Exception ex)
            {
                return NotFound();
            }
            return CreatedAtAction("updateJiraIssue", new { id = jiraissue.Id }, jiraissue);
        } 
    }
}
