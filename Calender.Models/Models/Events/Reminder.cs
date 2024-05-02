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
    [Table("Reminders")]
    public class Reminder  : ParentEntry
    {
        public int Id { get; set; }

        [Required]
        public int EventId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReminderDateTime { get; set; }

        public bool? IsSent { get; set; }

    }
}
