using Calendar.Models.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Auth.Interface.IRepository
{
    public interface IApplicationRepository
    {
        Task<Application> Insert(Application apps);
        Task<List<Application>> GetAll();
        Task<Application> GetById(int id);
        Task<Application> Update(Application apps);
        Task<Application> checkApplicationExist(string applicationName);
    }
}
