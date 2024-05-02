using Calendar.Auth.Interface.IRepository;
using Calendar.Auth.Interface.IService;
using Calendar.DbContexts.DbContexts;
using Calendar.Models.Models.Auth;
using Calendar.Repository.Repository.Generic;
using Calendar.Utilities.Auth;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calendar.Auth.Repository
{
    public class UserRepository: IUserRepository
    {
        // private readonly IGenericRepository<Models.Models.Auth.Applications> _objAppRepository;

        #region declaration
        private readonly IGenericRepository<User> _objUserRepository;
        private readonly IApplicationService _objAppService;
        private readonly IUserRolesRepository _objUserRolesRepository;
        #endregion

        #region constructor
        public UserRepository(IApplicationService Appservice, IGenericRepository<User> UserRepository, IUserRolesRepository UserRolesRepository)
        {
            _objAppService = Appservice;
            _objUserRepository = UserRepository;
            _objUserRolesRepository = UserRolesRepository;

        }
        #endregion


        #region Insert user
        public async Task<object> InsertUser(User users)
        {

            return await _objUserRepository.Insert(users);

        }
        #endregion

        #region Login
        public async Task<UserRequest> Login(RegisterRequest register)
        {

            //var param = new SqlParameter("@FirstName", "Bill");

            var email = "null";
            var password = "null";
            var application_id = "null";

            if (register != null)
            {
                email = register.Email != null ? register.Email : "null";
                password = register.Password != null ? register.Password : "null";
                application_id = register.ApplicationId != null ? register.ApplicationId.ToString() : "null";
            }

            //var userDetails = _context.Users.FromSqlRaw("GetStudents @FirstName", param).AsEnumerable().FirstOrDefault();
            string stored_proc = "exec sp_loginUser " +
                "@email = '" + email + "'," +
                "@pwd ='" + password + "'," +
                "@appId ='" + application_id + "'";

            var userDetailsSp = await _objUserRepository.FromSqlRaw(stored_proc);
            var userDetails = userDetailsSp.SingleOrDefault();
            UserRequest result = new UserRequest();
            if (userDetails == null)
            {
                UserRequest _objUser = new UserRequest();
                _objUser.Id = 0;
                _objUser.Email = register.Email;
                _objUser.Password = register.Password;
                _objUser.ApplicationId = register.ApplicationId;

                result.data = _objUser;
                return result;

            }
            else
            {
                UserRequest _objUserVM = new UserRequest
                {
                    Id = userDetails.Id,

                    Email = userDetails.Email,
                    Password = userDetails.Password,
                    Username = userDetails.Username,
                    ApplicationId = userDetails.ApplicationId,
                    ApplicationName = "http://" + register.ApplicationName,

                };
                return _objUserVM;



            }
        }
        #endregion




        #region update register
        public async Task<object> UpdateRegister(RegisterRequest register)
        {
            Application apps = new Application();
            User users = new User();
            UserRole userRoles = new UserRole();

            RegisterRequest registerVM = new RegisterRequest();


            apps.ApplicationName = register.ApplicationName;
            //apps.Description = register.Description;
            apps.IsActive = true;

            //await _objAppRepository.Update(apps);


            users.Username = register.Username;
            users.Email = register.Email;
            users.Password = register.Password;
            users.CreatedAt = DateTime.Now;
            //users.LastLoginDate= DateTime.Now;
            users.ApplicationId = apps.Id;
            //users.SecretKey = register.SecretKey;
            

            await _objUserRepository.Update(users);

            userRoles.ApplicationId = apps.Id;
            userRoles.UserId = users.Id;
            userRoles.RoleId = Convert.ToInt32(register.RoleId);
            //userRoles.AccessKey = register.AccessKey;

            //await _objUserRolesRepository.Update(userRoles);

            dynamic updatedRegisterExpand = new ExpandoObject();

            updatedRegisterExpand.user_id = users.Id;
            updatedRegisterExpand.username = users.Username;
            updatedRegisterExpand.password = users.Password;
            updatedRegisterExpand.email = users.Email;
            updatedRegisterExpand.application_id = users.ApplicationId;
            updatedRegisterExpand.created_date = users.CreatedAt;
            updatedRegisterExpand.application_name = apps.ApplicationName;
            updatedRegisterExpand.app_description = apps.Description;
            updatedRegisterExpand.user_role_id = userRoles.Id;
            updatedRegisterExpand.role_id = userRoles.RoleId;

            return updatedRegisterExpand;



        }
        #endregion

        #region checkEmailExist

        public async Task<User> checkEmailExist(string emailId)
        {
            var result = await _objUserRepository.checkEmailExist(emailId);
            return result;
        }

        #endregion

    }
}
