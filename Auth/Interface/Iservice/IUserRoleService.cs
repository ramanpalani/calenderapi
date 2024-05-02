using Calendar.Models.Models.Auth;
using Calendar.Utilities.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Auth.Interface.IService
{
    public interface IUserRoleService
    {
        Task<UserRole> InsertUserRoles(UserRole registerVM);
        Task<UserRole> checkUserRoleExist(int appId, int userId, int roleId);
    }
}
