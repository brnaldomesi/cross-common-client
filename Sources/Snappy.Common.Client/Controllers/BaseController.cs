﻿using System.IO;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

using Snappy.Common.Client.Helpers;
using Snappy.Common.Models.Shared;

namespace Snappy.Common.Client.Controllers
{
    [Authorize]
    public abstract class BaseController : Controller, ICurrentUser
    {
        public CurrentUser CurrentUser { get; set; }

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

            if (Request.Headers.ContainsKey(HeaderNames.UserAgent))
            {
                log.UserAgent = Request.Headers[HeaderNames.UserAgent].ToString();
                log.Platform = "";
                log.PlatformVersion = "";
                log.Browser = "";
                log.BrowserVersion = "";
            }

            if (Request.Headers.ContainsKey(HeaderHelper.HEADER_X_IP))
            {
                log.Ip = Request.Headers[HeaderHelper.HEADER_X_IP].ToString();
            }

            if (Request.Headers.ContainsKey(HeaderHelper.HEADER_X_COUNTRY))
            {
                log.Country = Request.Headers[HeaderHelper.HEADER_X_COUNTRY].ToString();
            }

            if (Request.Headers.ContainsKey(HeaderHelper.HEADER_X_CITY))
            {
                log.City = Request.Headers[HeaderHelper.HEADER_X_CITY].ToString();
            }

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