using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModule
{
    public class ParentEntry
    {
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set;}

        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set;}
    }
}
