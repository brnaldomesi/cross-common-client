using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc.Filters;

using Snappy.Common.Client.Controllers;

namespace Snappy.Common.Client.ActionFilters
{
    public class JournalFilter : ActionFilterAttribute
    {
        public string Message { get; set; }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var request = context.HttpContext.Request;

            var baseController = context.Controller as BaseController;
            if (baseController == null)
            {
                return;
            }

            var method = request.Method;
            var url = request.Path;
            var ip = request.Host.Host ?? "127.0.0.1";

            //var routeData = request.HttpContext.Route;
            //var currentAction = routeData.GetRequiredString("action");
            //var currentController = routeData.GetRequiredString("controller");
            var form = context.HttpContext.Request.Form;
            var formText = form.ToString();
            var queryParameters = HttpUtility.ParseQueryString(formText);
            var passwordText = queryParameters["password"];
            if (!string.IsNullOrWhiteSpace(passwordText))
            {
                queryParameters["password"] = new string(passwordText.ToCharArray().Select(s => '*').ToArray());
                formText = queryParameters.ToString();
            }

            //var journalRequest = new JournalInsertRequest(baseController.CurrentUser.Id, baseController.CurrentUser.Email, Message);
            //journalRequest.Ip = ip;
            //journalRequest.Url = url;
            //journalRequest.ActionMethod = currentAction;
            //journalRequest.Controller = currentController;
            //journalRequest.Form = formText;
            //journalRequest.Method = method;

            //journalRequest.Validate();

            //var journalService = new JournalService(new JournalRepository());
            //journalService.Insert(journalRequest);

            base.OnActionExecuted(context);
        }
    }
}