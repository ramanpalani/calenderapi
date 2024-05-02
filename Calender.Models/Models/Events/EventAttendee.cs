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
    [Table("EventAttendees")]
    public class EventAttendee :ParentEntry
    {
        public int Id { get; set; }

        [Required]
        public int EventId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string? ResponseStatus { get; set; }

    }
}
