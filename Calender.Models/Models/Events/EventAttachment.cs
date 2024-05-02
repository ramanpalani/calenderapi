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
    [Table("EventAttachments")]
    public class EventAttachment  :ParentEntry
    {
        public int Id { get; set; }

        [Required]
        public int EventId { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string? FileName { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string? FilePathOrURL { get; set; }
        
        

    }
}
