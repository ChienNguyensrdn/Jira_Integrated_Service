using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace Entities.Models 
{
    [Table("jiraaction")]
    public class JiraAction
    {
        public decimal Id
        {
            get; set;
        }
        [ForeignKey(nameof(Jiraissue))]
        public decimal? issueId
        {
            get; set;
        }
        public string Author
        {
            get; set;
        }
        public string actionType
        {
            get; set;
        }
        public string actionLevel
        {
            get; set;
        }
        public decimal? roleLevel
        {
            get; set;
        }
        public string actionBody
        {
            get; set;
        }
        public DateTime ? Created
        {
            get; set;
        }
        public string updateAuthor
        {
            get; set;
        }
        public DateTime? Updated
        {
            get; set;
        }
        public string actionColumn
        {
            get; set;
        }
    }
}
