﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedModule;

namespace Calendar.Models.Models.Auth
{
    [Table("Users")]
    public class User:ParentEntry
    {
        public int Id { get; set; }
       
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Username { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Email { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Password { get; set; }
        
        [Column(TypeName = "datetime")]
        public DateTime? LastLoginDate { get; set; }
        [Required]
        public int ApplicationId { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string SecretKey { get; set; }

        
    }

}
