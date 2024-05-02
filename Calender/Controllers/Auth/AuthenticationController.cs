using Calendar.Utilities.Auth;
using Calendar.Models.Models.Auth;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using Azure;
using Azure.Core;
using System.Threading;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using Calendar.Auth.Interface.IService;
using Calendar.Utilities.Response.Auth;
using Calendar.Utilities.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Calendar.Controllers.Auth
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IConfiguration _config;
        private readonly ILoginService _objILoginService;
        private readonly IDistributedCache _cache;

        public AuthenticationController(IConfiguration config, ILoginService objILoginService, IDistributedCache cache)
        {
            this._config = config;
            _objILoginService = objILoginService;
            _cache = cache;
        }




        #region sample token

        [AllowAnonymous]
        [HttpGet]
        [Route("sample-token")]
        public IActionResult SampleMethod()
        {
            var data = _config["Data:Contacts:Email"];
            //create claims details based on the user information
            var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _config["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.Now.ToString()),
                        new Claim("userId", "501"),
                        new Claim("domain_name","testdomain"),
                        new Claim("userName", "Test User Name"),

                        new Claim("emailaddress", "test@gmail.com"),
                         new Claim("fullName","Test Display Name"),
                    };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new System.IdentityModel.Tokens.Jwt.JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: signIn);

            return Ok(new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler().WriteToken(token));
        }
        #endregion

        #region Bearer token
        string GenerateJWTToken(TokenUser userInfo)
        {
            var token_handler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_config["Jwt:key"]);
            var token_descriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] {
                    new Claim("user_id", Convert.ToString(userInfo.Id)),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.Now.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                //Expires = DateTime.Now.AddSeconds(15),
                Issuer = _config["Jwt:Issuer"],
                Audience = _config["Jwt:Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = token_handler.CreateToken(token_descriptor);
            return token_handler.WriteToken(token);

        }
        #endregion
        #region Refresh token
        string RefreshJWTToken(TokenUser userInfo)
        {
            var security_Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(security_Key, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {


                new Claim("user_id",Convert.ToString(userInfo.Id)),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };
            var ref_token = new JwtSecurityToken(
                            issuer: _config["Jwt:Issuer"],
                            audience: _config["Jwt:Audience"],
                            claims: claims,
                            expires: DateTime.UtcNow.AddDays(30),
                            signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(ref_token);
        }
        #endregion

        #region Authenticate token

   
        #endregion

        #region Access token

        [AllowAnonymous]
        [HttpPost]
        [Route("access-token")]
        public IActionResult AccessTokenByRefresh([FromBody] dynamic refresh_token)
        {


            dynamic json1 = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(refresh_token.ToString());

            string ref_token = json1["refresh_token"];


            TokenUser _objUser = new TokenUser();

            var handler = new JwtSecurityTokenHandler();
            var jwt = handler.ReadJwtToken(ref_token);

            _objUser.Id = Convert.ToInt32(jwt.Claims.First(x => x.Type == "userId").Value);

            var token = GenerateJWTToken(_objUser);

            if (token == null)
            {
                return Unauthorized("Invalid Attempt!");
            }



            return Ok(token);
        }

        #endregion


        //#region check

        //[HttpGet]
        //[Route("check")]
        //public string check()
        //{
        //    // Set the expiry date of the cookie.
        //    CookieOptions options = new CookieOptions();
        //    options.Expires = DateTime.Now.AddDays(30);

        //    // Create a cookie with a suitable key and add it to the browser.
        //    Response.Cookies.Append("Name", "two", options);
        //    Response.Cookies.Delete("Name");

        //    return "welcome";
        //}
        //#endregion



        #region Register 
        [AllowAnonymous]
        [HttpPost]
        [Route("register")]

        public async Task<object> Register([FromBody] RegisterRequest register)
        {
            var result = await _objILoginService.InsertRegister(register);

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




        #region update register
        [HttpPut]
        [Route("update-register")]

        public async Task<object> UpdateRegister([FromBody] RegisterRequest register)
        {
            var result = await _objILoginService.UpdateRegister(register);

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

        #region Login
        [AllowAnonymous]
        [HttpPost]
        [Route("login")]

        public async Task<object> Login([FromBody] RegisterRequest register)
        {
            var result = await _objILoginService.Login(register);
            TokenUser user = AuthenticateUser(result);
            var response = new object();
            if (result.Id > 0)
            {

                AuthResponse authResponse = new AuthResponse();
                string cacheKey = "Calendar5b538w" + Convert.ToString(result.Id);

                byte[] cachedData = await _cache.GetAsync(cacheKey);

                if (cachedData != null)
                {
                    await _cache.RemoveAsync(cacheKey);
                    var cachedDataString = Encoding.UTF8.GetString(cachedData);
                    TokenUser tokenDetails = System.Text.Json.JsonSerializer.Deserialize<TokenUser>(cachedDataString);
                    response = new
                    {
                        success = true,
                        statusCode = HttpStatusCode.OK,
                        data = tokenDetails,
                    };
                    return response;
                    //return Ok(tokenDetails);
                }

                else
                {


                    if (result != null)
                    {



                       
                        var tokenString = GenerateJWTToken(user);
                        var refreshTokenString = RefreshJWTToken(user);

                        // Set the expiry date of the cookie.
                        CookieOptions options = new CookieOptions();
                        options.Expires = DateTime.Now.AddDays(30);

                        // Create a cookie with a suitable key and add it to the browser.
                        //Response.Cookies.Append("Name", "one", options);
                        Response.Cookies.Append("refresh_token", refreshTokenString, options);


                        user.AccessToken = tokenString;
                        user.RefreshToken = refreshTokenString;



                        //authResponse.redis_key = "Calendar5b538w" + user.Id;




                        string cachedDataString = System.Text.Json.JsonSerializer.Serialize(user);
                        var dataToCache = Encoding.UTF8.GetBytes(cachedDataString);

                        DistributedCacheEntryOptions distributionOptions = new DistributedCacheEntryOptions()
                            .SetAbsoluteExpiration(DateTime.UtcNow.AddMinutes(50))
                            .SetSlidingExpiration(TimeSpan.FromMinutes(30));

                        await _cache.SetAsync(cacheKey, dataToCache, distributionOptions);


                    }

                }


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
                        data = user,
                    };
                    return response;
                }
            }
            else
            {
                response = new
                {
                    success = false,
                    statusCode = HttpStatusCode.BadRequest,
                    data = "Invalid email or password",
                };
                return response;
            }

        }
        #endregion

        #region authenticate user
        TokenUser AuthenticateUser(UserRequest _objUser)
        {
            TokenUser tokenUser = new TokenUser();

            tokenUser.Id = Convert.ToInt32(_objUser.Id);
            return tokenUser;
        } 
        #endregion








    }
}