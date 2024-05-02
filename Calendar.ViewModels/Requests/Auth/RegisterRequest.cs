using Calendar.Models.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Utilities.Auth
{
    public class RegisterRequest
    {
        public int? Id { get; set; }

        public string? Username { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }
        public int? RoleId { get; set; }
        public string? ApplicationName { get; set; }
        public int? ApplicationId { get; set; }

    }
}
