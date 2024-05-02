using Calendar.Models.Models.Auth;
using Calendar.Utilities.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Auth.Interface.IBL
{
    public interface IApplicationBL
    {
        Task<Application> InsertApplication(Application apps);
        Task<List<Application>> GetApplication();
        Task<Application> GetApplicationById(int id);
        Task<Application> checkApplicationExist(string applicationName);
    }
}
