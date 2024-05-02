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
    [Table("RecurringEvents")]
    public class RecurringEvent : ParentEntry
    {
        public int Id { get; set; }

        [Required]
        public int EventId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? RecurrencePattern { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecurrenceStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecurrenceEndDate { get; set; }
        [Column(TypeName = "varchar(max")]
        public string? Exceptions { get; set; }

    }
}
