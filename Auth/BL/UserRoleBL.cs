using Calendar.Auth.Interface.IBL;
using Calendar.Auth.Interface.IRepository;
using Calendar.Models.Models.Auth;
using Calendar.Utilities.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Auth.BL
{
    public class UserRoleBL   : IUserRoleBL
    {
        #region declaration
        private readonly IUserRolesRepository _objUserRolesRepository;
        #endregion

        #region constructor
        public UserRoleBL(IUserRolesRepository UserRolesRepository)
        {
            _objUserRolesRepository = UserRolesRepository;
        }
        #endregion
        #region Insert userRoles
        public async Task<UserRole> InsertUserRoles(UserRole userRoles)
        {

            dynamic list = await _objUserRolesRepository.Insert(userRoles);
            return list;
        }
        #endregion

        #region check userRoles Exist
        public async Task<UserRole> checkUserRoleExist(int appId, int userId, int roleId)
        {

            dynamic list = await _objUserRolesRepository.checkUserRoleExist(appId, userId, roleId);
            return list;
        }
        #endregion
        
    }
}
