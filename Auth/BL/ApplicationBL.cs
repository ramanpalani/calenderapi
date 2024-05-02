using Calendar.Auth.Interface.IBL;
using Calendar.Auth.Interface.IRepository;
using Calendar.Models.Models.Auth;
using Calendar.Utilities.Auth;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Auth.BL
{
    public class ApplicationBL  : IApplicationBL
    {

        #region declaration
        private readonly IApplicationRepository _objApplicationRepository;
        #endregion

        #region constructor
        public ApplicationBL(IApplicationRepository ApplicationRepository)
        {
            _objApplicationRepository = ApplicationRepository;
        }
        #endregion
        #region Application insert
        public async Task<Application> InsertApplication(Application apps)
        {
          
            
                apps.CreatedAt = DateTime.Now;
                apps.IsActive = true;
                var list = await _objApplicationRepository.Insert(apps);
                return list;
            
           
        }
        #endregion

        #region Get Application 
        public async Task<List<Application>> GetApplication()
        {

            var list = await _objApplicationRepository.GetAll();
            return list;
        }
        #endregion

        #region Get ApplicationById 
        public async Task<Application> GetApplicationById(int id)
        {

            var list = await _objApplicationRepository.GetById(id);
            return list;
        }
        #endregion

        #region Application Exist
        public async Task<Application> checkApplicationExist(string applicationName)
        {

            var result = await _objApplicationRepository.checkApplicationExist(applicationName);
            return result;
        }
        #endregion
    }
}
