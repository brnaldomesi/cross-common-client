using System.IO;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Snappy.Common.Models.Shared;

namespace Snappy.Common.Client.Controllers
{
    [Authorize]
    public abstract class BaseController : Controller
    {
        public RedirectResult RedirectToHome()
        {
            return Redirect("/");
        }

        public RedirectResult RedirectToAccessDenied()
        {
            return Redirect("/Home/AccessDenied");
        }

        public ClientLogInfo GetClientInfoLog()
        {
            var log = new ClientLogInfo();

            log.UserAgent = Request.Headers["User-Agent"].ToString();
            log.Ip = HttpContext?.Connection?.RemoteIpAddress?.ToString();
            log.IpLocation = "";
            log.Platform = "";
            log.Browser = "";

            return log;
        }

        protected string GetRequestBodyString()
        {
            string bodyStr;
            using (var reader = new StreamReader(Request.Body, Encoding.UTF8, true, 1024, true))
            {
                bodyStr = reader.ReadToEnd();
            }

            return bodyStr;
        }
    }
}