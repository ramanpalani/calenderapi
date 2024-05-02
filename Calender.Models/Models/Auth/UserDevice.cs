using SharedModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Models.Models.Auth
{
    [Table("UserDevices")]
    public class UserDevice :ParentEntry
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [MaxLength(500)]
        public string? PlatformDetails { get; set; }

        [Required]
        public int DeviceId { get; set; }

    }
}
