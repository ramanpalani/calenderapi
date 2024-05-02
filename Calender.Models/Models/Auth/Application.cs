using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedModule;

namespace Calendar.Models.Models.Auth
{
    [Table("Applications")]
    public class Application : BaseEntry  
    {
        

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string? ApplicationName { get; set; }

        [Column(TypeName = "text")]
        public string? Description { get; set; }

       

    }
}
