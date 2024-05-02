using Calendar.Models.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Auth.Interface.IBL
{
    public interface IUserRoleBL
    {
        Task<UserRole> InsertUserRoles(UserRole userRoles);
        Task<UserRole> checkUserRoleExist(int appId, int userId, int roleId);
    }
}
