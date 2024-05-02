using Calendar.Utilities.Auth;
using Calendar.Models.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calendar.Auth.Interface.IRepository;
using Calendar.Repository.Repository.Generic;

namespace Calendar.Auth.Repository
{
    public class ApplicationRepository  : IApplicationRepository
    {
        #region declaration
        private readonly IGenericRepository<Application> _objGenRepository;
        #endregion

        #region constructor
        public ApplicationRepository(IGenericRepository<Application> AppRepository)
        {
            _objGenRepository = AppRepository;

        }
        #endregion

        #region Application insert
        public async Task<Application> Insert(Application applications)
        {
            var result = await _objGenRepository.Insert(applications);
            return result;
        }
        #endregion

        #region Application Get
        public async Task<List<Application>> GetAll()
        {
            var result = await _objGenRepository.GetAll();
            return result;
        }
        #endregion

        #region Application GetById
        public async Task<Application> GetById(int id)  
        {
            var result = await _objGenRepository.FindById(id);
            return result;
        }
        #endregion

        #region Application update
        public async Task<Application> Update(Application applications)
        {
            var result = await _objGenRepository.Update(applications);
            return result;
        }
        #endregion

        #region check Application Exist
        public async Task<Application> checkApplicationExist(string applicationName)
        {
            var result = await _objGenRepository.checkApplicationExist(applicationName);
            return result;
        }
        #endregion

    }
}
