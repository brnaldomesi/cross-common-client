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
            log.Ip = "";
            log.IpLocation = "";
            log.Platform = "";
            log.Browser = "";

            return log;
        }
    }
}