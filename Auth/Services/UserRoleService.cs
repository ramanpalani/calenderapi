using Calendar.Auth.Interface.IBL;
using Calendar.Auth.Interface.IRepository;
using Calendar.Auth.Interface.IService;
using Calendar.Auth.Repository;
using Calendar.Models.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Auth.Services
{
    public class UserRoleService    : IUserRoleService
    {
        #region declaration
        private readonly IUserRoleBL _objUserRoleBL;
        private readonly IUserRolesRepository _objUserRoleRepository;
        #endregion
        #region constructor
        public UserRoleService(IUserRoleBL UserRoleBL, IUserRolesRepository UserRoleRepository)
        {
            _objUserRoleBL = UserRoleBL;
            _objUserRoleRepository = UserRoleRepository;
        }
        #endregion

        #region userroles insert
        public async Task<UserRole> InsertUserRoles(UserRole userRoles)
        {
            var result = await _objUserRoleBL.InsertUserRoles(userRoles);
            return result;

        }
        #endregion
        #region check userroles exist
        public async Task<UserRole> checkUserRoleExist(int appId, int userId, int roleId)
        {
            var result = await _objUserRoleBL.checkUserRoleExist(appId, userId, roleId);
            return result;

        }
        #endregion

        

    }
}
