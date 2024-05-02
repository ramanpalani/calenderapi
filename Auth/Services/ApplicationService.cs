using Calendar.Auth.BL;
using Calendar.Auth.Interface.IBL;
using Calendar.Auth.Interface.IRepository;
using Calendar.Auth.Interface.IService;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calendar.Models.Models.Auth;

namespace Calendar.Auth.Services
{
    public class ApplicationService : IApplicationService
    {
        #region declaration
        private readonly IApplicationBL _objApplicationBL;
        private readonly IApplicationRepository _objAppRepository; 
        #endregion

        #region constructor
        public ApplicationService(IApplicationBL ApplicationBL, IApplicationRepository applicationRepository)
        {
            _objApplicationBL = ApplicationBL;
            _objAppRepository = applicationRepository;
        } 
        #endregion

        #region Application Insert
        public async Task<Application> InsertApplication(Application apps)
        {
            var result = await _objApplicationBL.InsertApplication(apps);
            return result;

        }
        #endregion


        #region Application get
        public async Task<List<Application>> GetApplication()
        {
            var result = await _objApplicationBL.GetApplication();
            return result;

        }
        #endregion

        #region Application get
        public async Task<Application> GetApplicationById(int id)
        {
            var result = await _objApplicationBL.GetApplicationById(id);
            return result;

        }
        #endregion

        #region Application Exist
        public async Task<Application> checkApplicationExist(string applicationName)
        {
            var result = await _objApplicationBL.checkApplicationExist(applicationName);
            return result;

        }
        #endregion

    }
}
