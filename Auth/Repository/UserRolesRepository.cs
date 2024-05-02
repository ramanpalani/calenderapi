using Calendar.Auth.Interface.IRepository;
using Calendar.Models.Models.Auth;
using Calendar.Repository.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Auth.Repository
{
    public class UserRolesRepository  : IUserRolesRepository
    {
        #region declaration
        private readonly IGenericRepository<UserRole> _objUserRolesRepository;
        #endregion

        #region constructor
        public UserRolesRepository(IGenericRepository<UserRole> UserRolesRepository)
        {
            _objUserRolesRepository = UserRolesRepository;

        }
        #endregion

        #region userrole insert
        public async Task<UserRole> Insert(UserRole userRoles)
        {
            var result = await _objUserRolesRepository.Insert(userRoles);
            return result;
        }
        #endregion

        #region userrole update
        public async Task<UserRole> Update(UserRole UserRolesRepository)
        {
            var result = await _objUserRolesRepository.Update(UserRolesRepository);
            return result;
        }
        #endregion


        #region check UserRoleExist

        public async Task<UserRole> checkUserRoleExist(int appId, int userId, int roleId)
        {
            var result = await _objUserRolesRepository.checkuserRoleExist(appId,userId,roleId);
            return result;
        }

        #endregion


    }
}
