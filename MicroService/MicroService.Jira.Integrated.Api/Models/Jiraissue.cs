using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MicroService.Jira.Integrated.Api.Models
{
    [Table("jiraissue")]
    public class Jiraissue
    {
        public decimal Id { get; set; }
        public string pkey { get; set; }
        public decimal? Project { get; set; } 
        public string Reporter { get; set; }
        public string Assignee { get; set; }
        public string issueType { get; set; }
        public string Summary { get; set; }
        public string  Description { get; set; }
        public string Environment { get; set; }
        public string Priority { get; set; }
        public string  Resolution { get; set; }
        public string issueStatus { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Dudate { get; set; }
        public DateTime? resolutionDate { get; set; }
        public decimal? Votes { get; set; }
        public decimal?Watches { get; set; }
        public decimal? timeorigianEstimate { get; set; }
        public decimal? timeEstimate { get; set; }
        public decimal? timeSpent { get; set; } 
        public decimal? WorkFlow_Id { get; set; } 
        public decimal? Security { get; set; } 
        public decimal? Fixfor { get; set; }
        public decimal? Component { get; set; }
    }
}
