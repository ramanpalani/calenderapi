using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Calendar.Auth.Interface.IService;
using Calendar.Models.Models.Auth;

namespace Calendar.Controllers.Auth
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private IConfiguration _config;
        private readonly IApplicationService _objIAppService;
        
        public ApplicationController(IConfiguration config, IApplicationService objIAppService)
        {
            this._config = config;
            _objIAppService = objIAppService;
            
        }


        #region Insert Application 

        [HttpPost]
        [Route("insert-app")]

        public async Task<object> InsertApplication([FromBody] Application app)
        {
            var exist = await _objIAppService.checkApplicationExist(app.ApplicationName);

            var response = new object();

            if (exist.Id == 0)
            {


                var result = await _objIAppService.InsertApplication(app);

               
                if (result == null)
                {
                    response = new
                    {
                        success = false,
                        statusCode = HttpStatusCode.BadRequest,
                        data = DBNull.Value,
                    };
                    return response;
                }
                else
                {
                    response = new
                    {
                        success = true,
                        statusCode = HttpStatusCode.OK,
                        data = result,
                    };
                    return response;
                }
            }
            else
            {
                response = new
                {
                    success = true,
                    statusCode = HttpStatusCode.OK,
                    data = "Application Already exists",
                };
                return response;

            }

        }
        #endregion


        #region Get Application 

        [HttpGet]
        [Route("get-apps")]

        public async Task<object> GetApplication()
        {
            var result = await _objIAppService.GetApplication();

            var response = new object();
   

            if (result == null)
            {
                response = new
                {
                    success = false,
                    statusCode = HttpStatusCode.BadRequest,
                    data = DBNull.Value,
                };
                return response;
            }
            else
            {
                response = new
                {
                    success = true,
                    statusCode = HttpStatusCode.OK,
                    data = result,
                };
                return response;
            }

        }
        #endregion

        #region Get ApplicationById 

        [HttpGet]
        [Route("{app_id}/get-apps-by-id")]

        public async Task<object> GetApplicationById(int app_id)
        {
            var result = await _objIAppService.GetApplicationById(app_id);

            var response = new object();


            if (result == null)
            {
                response = new
                {
                    success = false,
                    statusCode = HttpStatusCode.BadRequest,
                    data = DBNull.Value,
                };
                return response;
            }
            else
            {
                response = new
                {
                    success = true,
                    statusCode = HttpStatusCode.OK,
                    data = result,
                };
                return response;
            }

        }
        #endregion


    }
}
