using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities.Models
{
    [Table("issuestatus")]
    public class IssueStatus
    {
        public decimal Id { get; set; }
        public decimal Sequence { get; set; }
        public string pName { get; set; }
        public string Description { get; set; }
        public string iconUrl { get; set; }
    }
}
