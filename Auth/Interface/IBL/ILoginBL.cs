using Calendar.Utilities.Auth;
using Calendar.Models.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Auth.Interface.IBL
{
    public interface ILoginBL
    {
        Task<object> InsertRegister(User users);
      
        Task<object> UpdateRegister(RegisterRequest registerVM);
        Task<UserRequest> Login(RegisterRequest registerVM);
        Task<User> checkEmailExist(string emailId);



    }
}
