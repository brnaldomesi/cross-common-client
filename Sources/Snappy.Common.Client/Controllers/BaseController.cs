using Microsoft.AspNetCore.Mvc;
using Snappy.Common.Models.Shared;

namespace Snappy.Common.Client.Controllers
{
    public class BaseController : Controller
    {
        public CurrentUser CurrentUser { get; set; }

        public BaseController()
        {
            
        }

        public RedirectResult RedirectToHome()
        {
            return Redirect("/");
        }

        public RedirectResult RedirectToAccessDenied()
        {
            return Redirect("/Home/AccessDenied");
        }
    }
}