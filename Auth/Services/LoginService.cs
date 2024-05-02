using Calendar.Auth.Interface.IBL;
using Calendar.Auth.Interface.IService;
using Calendar.Models.Models.Auth;
using Calendar.Utilities.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calendar.Auth.Services
{
    public class LoginService : ILoginService
    {
        #region Declaration

        private readonly ILoginBL _objLoginBL;
        private readonly IApplicationService _objAppService;
        private readonly IUserRoleService _objUserRoleService;

        Application apps;
        User users;
        UserRole userRoles;
        RegisterRequest registerVM;
        #endregion

        #region expando declaration
        dynamic registerExpand = new ExpandoObject();
        #endregion

        #region Constructor
        public LoginService(ILoginBL LoginBL, IApplicationService appService, IUserRoleService userRoleService)
        {
            _objLoginBL = LoginBL;
            _objAppService = appService;
            _objUserRoleService = userRoleService;

        }
        #endregion

        #region Register Insert
        public async Task<object> InsertRegister(RegisterRequest register)
        {
            apps = new Application();
            users = new User();
            userRoles = new UserRole();
            registerVM = new RegisterRequest();
            registerExpand = new ExpandoObject();
            dynamic userList = "";
            dynamic userRolesList = "";
            dynamic appList = "";
            string userName = "";
            string Email = "";
            string createdDate = "";
            bool isActive = false;
            string applicationName = "";
            string appDescription = "";
            bool appActive = false;

            int appId = 0;
            int existUserId = 0;
            int roleId = 0;
            int userRoleId = 0;

            


            var existAppList = await _objAppService.checkApplicationExist(register.ApplicationName);
            appId = existAppList.Id;
            #region application insert
            if (appId == 0)
            {

                apps.ApplicationName = register.ApplicationName;
                //apps.Description = register.Description;
                apps.CreatedAt = DateTime.UtcNow;
                apps.CreatedBy = 0;
                apps.IsActive = true;
                
                appList = await _objAppService.InsertApplication(apps);
                appId = appList.Id;
                applicationName = appList.ApplicationName;
                appActive = appList.IsActive;
            }
            else
            {
                appId = existAppList.Id;
                applicationName = existAppList.ApplicationName;
                appActive = (bool)existAppList.IsActive;
            }

            #endregion


            var existUserList = await _objLoginBL.checkEmailExist(register.Email);

            existUserId = existUserList.Id;

            #region users insert
            if (existUserId == 0)
            {
                
                users.ApplicationId = appId;
                users.Username = register.Username;
                users.Email = register.Email;
                users.Password = register.Password;
                users.SecretKey = "123";
                users.CreatedAt = DateTime.UtcNow;
                users.CreatedBy = 0;

                userList = await _objLoginBL.InsertRegister(users);
       
                userName = userList.Username;
                Email=userList.Email;
                appId = userList.ApplicationId;
                createdDate = userList.CreatedAt.ToString();
                isActive = (bool)userList.IsActive;



                existUserId = users.Id;
            }
            else
            {
                userName = existUserList.Username;
                Email = existUserList.Email;
                existUserId = existUserList.Id;
                appId = existUserList.ApplicationId;
                createdDate = existUserList.CreatedAt.ToString();
                
            }
            #endregion

            var existUserRoleList = await _objUserRoleService.checkUserRoleExist(appId, existUserId, Convert.ToInt32(register.RoleId));
            userRoleId = existUserRoleList.Id;
            #region userRoles insert
            if (userRoleId == 0)
            {
               
                userRoles.ApplicationId = appId;
                userRoles.UserId = existUserId;
                userRoles.RoleId = Convert.ToInt32(register.RoleId);
                userRoles.AccessKey = "123";
                userRoles.IsActive = true;
                userRoles.IsDeleted = false;
                userRoles.CreatedAt = DateTime.UtcNow;
                userRoles.CreatedBy = 0;

                userRolesList = await _objUserRoleService.InsertUserRoles(userRoles);

                userRoleId= userRolesList.Id;
                roleId=userRolesList.RoleId;
            
          
            #endregion


            #region return response
          

                registerExpand.user_id = existUserId;
                registerExpand.username = userName;
                registerExpand.email = Email;
                registerExpand.application_id = appId;
                registerExpand.created_date = createdDate;
                registerExpand.is_active = isActive;
                registerExpand.application_name = applicationName;
                registerExpand.app_description = appDescription;
                registerExpand.app_active = appActive;
                registerExpand.user_role_id = userRoleId;
                registerExpand.role_id = roleId;
                return registerExpand;
            }
            else
            {
                return registerExpand.message = "User already exists";
            }
            #endregion
        }

        #endregion
        #region update register
        public async Task<object> UpdateRegister(RegisterRequest registerVM)
        {
            dynamic list = await _objLoginBL.UpdateRegister(registerVM);

            return list;
        }
        #endregion

        #region login
        public async Task<UserRequest> Login(RegisterRequest registerVM)
        {
            dynamic list = await _objLoginBL.Login(registerVM);

            return list;
        } 
        #endregion
    }
}
