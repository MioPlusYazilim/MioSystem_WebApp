using Microsoft.AspNetCore.Http;
using Portal.Api.Data.Context;
using Portal.Model;
using System;
using System.Linq;

namespace Portal.Api.DataServis
{
    public interface ISessionService : IDisposable
    {
        SessionInformation sessionInfo { get; set; }
    }
    public class SessionService : ISessionService
    {
        public SessionInformation sessionInfo { get; set; }
        private GlobalDataContext globalContext;
        public SessionService(IHttpContextAccessor _httpContextAccessor, GlobalDataContext _globalContext)
        {
            globalContext = _globalContext;
            
            getRequestUser(_httpContextAccessor.HttpContext);
        }
        void getRequestUser(HttpContext httpContext)
        {
            try
            {
                var User = httpContext.User;
                if (User != null)
                {
                    sessionInfo = new SessionInformation();
                    sessionInfo.Language = httpContext.Request.Headers["Accept-Language"].ToString();
                    sessionInfo.EmployeeID = Convert.ToInt32(User.Claims.First(claim => claim.Type == "employeeID").Value);
                    sessionInfo.AuthoryGroup = Convert.ToInt32(User.Claims.First(claim => claim.Type == "authoryGroup").Value);
                    sessionInfo.AuthoryLevel = Convert.ToInt32(User.Claims.First(claim => claim.Type == "authoryLevel").Value);
                    sessionInfo.ClientKey = Convert.ToString(User.Claims.First(claim => claim.Type == "clientKey").Value);
                    sessionInfo.CustomerIDs = (Convert.ToString(User.Claims.First(claim => claim.Type == "customerIDs").Value) ?? "0").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                    sessionInfo.CustomerGroupIDs = (Convert.ToString(User.Claims.First(claim => claim.Type == "customerGroupIDs").Value) ?? "0").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                    sessionInfo.DepartmentID= Convert.ToInt32(User.Claims.First(claim => claim.Type == "departmentID").Value);
                }
            }
            catch (System.Exception ex)
            {
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
