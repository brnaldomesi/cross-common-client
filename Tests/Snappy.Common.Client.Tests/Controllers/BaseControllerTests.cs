using Microsoft.AspNetCore.Mvc;

using NUnit.Framework;
using Shouldly;

using Snappy.Common.Client.Controllers;

namespace Snappy.Common.Tests.Controllers
{
    [TestFixture]
    public class BaseControllerTests
    {
        [Test]
        public void BaseController_is_abstract()
        {
            typeof(BaseController).IsAbstract.ShouldBeTrue();
        }

        [Test]
        public void BaseController_RedirectToHome()
        {
            var controller = new TestController();
            var result = controller.RedirectToHome();
            result.ShouldBeAssignableTo<RedirectResult>();
            result.Url.ShouldBe("/");
        }

        [Test]
        public void BaseController_RedirectToAccessDenied()
        {
            var controller = new TestController();
            var result = controller.RedirectToAccessDenied();
            result.ShouldBeAssignableTo<RedirectResult>();
            result.Url.ShouldBe("/Home/AccessDenied");
        }
    }
}