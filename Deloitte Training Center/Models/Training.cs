using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Deloitte_Training_Center.Models
{
    public class Training
    {
        public int Id { get; set; }
        
        [DisplayName("Training Name")]
        public required string name{ get; set; }

        [DisplayName("Enrollment Date")]
        [DataType(DataType.Date)]
        public DateTime dateTime{ get; set; }

        [DisplayName("Prerequisite")]
        public string? prequisite{ get; set; }

        [DisplayName("Duration")]
        public TimeSpan duration{ get; set; }

        [DisplayName("Credit")]
        public decimal credit{ get; set; }
    }
}
