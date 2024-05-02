using Calendar.Utilities.Auth;
using Calendar.Auth.Interface.IBL;
using Calendar.Models.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Calendar.Auth.Interface.IRepository;
using Calendar.Utilities.Dto;
using Calendar.Auth.Interface.IService;

namespace Calendar.Auth.BL
{
    public class LoginBL:ILoginBL
    {
        #region declaration
        private readonly IUserRepository _objLoginRepository;
        private readonly IPasswordEncryptionService _objPasswordEncryptionService;
        #endregion

        #region constructor
        public LoginBL(IUserRepository objLoginRepository, IPasswordEncryptionService objPasswordEncryptionService)
        {
            _objLoginRepository = objLoginRepository;
            _objPasswordEncryptionService = objPasswordEncryptionService;
        }
        #endregion


        #region Insert user
        public async Task<object> InsertRegister(User users)
        {
            if ((users.Password != null) && (users.Password != string.Empty))
            {
              
               users.Password=_objPasswordEncryptionService.EncryptPassword(users.Password);
              
            }

            dynamic list = await _objLoginRepository.InsertUser(users);
            return list;

        }
        #endregion

        #region Update user
        public async Task<object> UpdateRegister(RegisterRequest registerVM)
        {
            dynamic list = await _objLoginRepository.UpdateRegister(registerVM);
            return list;
        }
        #endregion

        #region Login
        public async Task<UserRequest> Login(RegisterRequest registerVM)
        {

            if ((registerVM.Password != null) && (registerVM.Password != string.Empty))
            {
                
                registerVM.Password = _objPasswordEncryptionService.EncryptPassword(registerVM.Password);
            }

            dynamic list = await _objLoginRepository.Login(registerVM);
            return list;
        }
        #endregion
        #region checkEmailExist

        public async Task<User> checkEmailExist(string emailId)
        {
            var result = await _objLoginRepository.checkEmailExist(emailId);
            return result;
        }

        #endregion


    }
}
