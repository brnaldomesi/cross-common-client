using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Client.Tests.Models.ViewModels.Base;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class LogOnModelTests : BaseViewModelTest<LogOnModel>
    {
        public LogOnModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void LogOnModel_has_title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "log_on_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD, new[] { "email_required_error_message" })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.PASSWORD, new[] { "email_is_not_valid_error_message" })]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.EMPTY_STRING, new[] { "password_required_error_message" })]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.STRING, new[] { "password_is_not_valid_error_message" })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING, new[] { "email_is_not_valid_error_message",
                                                                        "password_is_not_valid_error_message" })]
        public void LogOnModel_InputErrorMessages(string email, string password, string[] errorMessage)
        {
            SystemUnderTest.Email = email;
            SystemUnderTest.Password = password;

            AssertModelValidation(SystemUnderTest.IsValid());
            AssertInputErrorMessages(SystemUnderTest.InputErrorMessages, errorMessage);
        }

        [Test]
        public void LogOnModel_EmailInputModel()
        {
            AssertInputModel(SystemUnderTest.EmailInput, "Email", "email", true);
        }

        [Test]
        public void LogOnModel_PasswordInputModel()
        {
            AssertInputModel(SystemUnderTest.PasswordInput, "Password", "password", true);
        }
    }
}