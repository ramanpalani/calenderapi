using SharedModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Models.Models.Events
{
    [Table("Locations")]
    public class Location :ParentEntry
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string? LocationName { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string? Address { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Latitude { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Longitude { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string? Description { get; set; }
       
        

    }
}
