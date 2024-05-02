using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Utilities.Dto
{
    public class UserRoles
    {
        public int Id { get; set; }

        public int? ApplicationId { get; set; }

        public int? UserId { get; set; }

        public int? RoleId { get; set; }

        public string? AccessKey { get; set; }
    }
}
