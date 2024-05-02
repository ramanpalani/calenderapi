using Calendar.Models.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Auth.Interface.IService
{
    public interface IApplicationService
    {
        Task<Application> InsertApplication(Application registerVM);
        Task<List<Application>> GetApplication();
        Task<Application> GetApplicationById(int id);
        Task<Application> checkApplicationExist(string applicationName);
    }
}
