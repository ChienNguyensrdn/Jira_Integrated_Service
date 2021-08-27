using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace Entities.Models
{
    [Table("worklog")]
    public class WorkLog
    {
        public decimal Id { get; set; }
        [ForeignKey(nameof(Jiraissue ))]
        public decimal? issueId
        {
            get; set;
        }
        public string Author
        {
            get; set;
        }
        public string groupLevel
        {
            get; set;
        }
        public decimal? roleLevel
        {
            get; set;
        }
        public string workLogBody
        {
            get; set;
        }
        public DateTime? Created
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
        public DateTime? startDate
        {
            get; set;
        }
        public decimal? timeWorked
        {
            get; set;
        }
    }
}
