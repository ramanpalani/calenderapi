using SharedModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Models.Models.Auth
{
    [Table("Roles")]
    public class Role  :ParentEntry
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? RolesName { get; set; }

    }
}
