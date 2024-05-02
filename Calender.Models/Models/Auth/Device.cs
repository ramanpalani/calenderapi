using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedModule;

namespace Calendar.Models.Models.Auth
{
    [Table("Devices")]
    public class Device: BaseEntry
    {
       
        public bool? IsAppPlatformBlocked { get; set; }

        [Column(TypeName = "varchar(100)")]
        
        public string? Platform { get; set; }

    }
}
