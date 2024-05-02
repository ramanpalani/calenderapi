using Calendar.Utilities.Auth;
using Calendar.Models.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Auth.Interface.IRepository
{
    public interface IUserRepository
    {
        Task<dynamic> InsertUser(User users);
        
        Task<UserRequest> Login(RegisterRequest registerVM);
        Task<dynamic> UpdateRegister(RegisterRequest registerVM);

        Task<User> checkEmailExist(string emailId);

    }
}
