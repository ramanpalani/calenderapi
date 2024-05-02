using Calendar.Utilities.Auth;
using Calendar.Models.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Auth.Interface.IService
{
    public interface ILoginService
    {
       
        Task<object> InsertRegister(RegisterRequest registerVM);
        Task<object> UpdateRegister(RegisterRequest registerVM);

        Task<UserRequest> Login(RegisterRequest registerVM);
       
    }
}
