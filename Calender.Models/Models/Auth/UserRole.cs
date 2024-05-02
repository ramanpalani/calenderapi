using SharedModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Models.Models.Auth
{
    [Table("UserRoles")]
    public class UserRole :BaseEntry
    {
        
        [Required]
        public int ApplicationId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int RoleId { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string AccessKey { get; set; }
    }
}
