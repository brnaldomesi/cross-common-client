﻿using Microsoft.AspNetCore.Mvc;

namespace Snappy.Common.Client.Controllers
{
    public class BaseController : Controller
    {
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