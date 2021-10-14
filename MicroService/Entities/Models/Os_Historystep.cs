using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Entities.Models
{
    [Table("os_historystep")]
    public class Os_Historystep
    {
        public decimal Id { get; set; }
        //one-to-many relationship between Jiraissue and os_historystep
        public decimal EntryId { get; set; }
        //public Jiraissue Jiraissue { get; set; }
        [ForeignKey(nameof(IssueStatus))]
        public decimal   StepId { get; set; }
        public decimal ActionId { get; set; }
        public string Owner { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public string Status { get; set; }
        public string Caller { get; set; }

       
    }
}
