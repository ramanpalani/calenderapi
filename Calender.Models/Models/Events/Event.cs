using SharedModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Models.Models.Events
{
   
    [Table("Events")]
    public class Event :ParentEntry
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Title { get; set; }
        [Column(TypeName = "text")]
        public string? Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Required]
        public int UserId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? PrivacySettings { get; set; }
        [Required]
        public int EventPeriodId { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string? Color { get; set; }
       
        [Required]
        public int LocationId { get; set; }

        public int ApplicationId { get; set; }

        public int RoleId { get; set; }

    }

}