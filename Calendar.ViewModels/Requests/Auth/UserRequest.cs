using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Utilities.Auth
{
    public class UserRequest
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? LastLoginDate { get; set; }

        public int? ApplicationId { get; set; }

        public string? ApplicationName { get; set; }

        public string? SecretKey { get; set; }

        public bool? IsDeleted { get; set; }

        public bool? IsActive { get; set; }

        public UserRequest? data { get; set; }

    }
}
