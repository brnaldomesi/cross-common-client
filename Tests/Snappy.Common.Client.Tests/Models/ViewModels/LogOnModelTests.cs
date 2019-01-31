using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class LogOnModelTests
    {
        [Test]
        public void LogOnModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "log_on_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD, new string[]
        {
            "email_required_error_message"
        })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.PASSWORD, new string[]
        {
            "email_is_not_valid_error_message"
        })]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.EMPTY_STRING, new string[]
        {
            "password_required_error_message"
        })]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.STRING, new string[]
        {
            "password_is_not_valid_error_message"
        })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING, new string[]
        {
            "email_is_not_valid_error_message",
            "password_is_not_valid_error_message"
        })]
        public void LogOnModel_Validates_AddsErrorMessages(string email, string password, string[] errorMessage)
        {
            var model = GetModel();
            model.Email = email;
            model.Password = password;

            Assert.False(model.IsValid());
            foreach (var message in errorMessage)
            {
                Assert.True(model.InputErrorMessages.Contains(message));
            }
        }

        [Test]
        public void LogOnModel_has_EmailInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.EmailInput.Name, "Email");
            Assert.AreEqual(model.EmailInput.LabelKey, "email");
            Assert.True(model.EmailInput.IsRequired);
            Assert.IsEmpty(model.EmailInput.Value);
        }

        [Test]
        public void LogOnModel_has_PasswordInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.PasswordInput.Name, "Password");
            Assert.AreEqual(model.PasswordInput.LabelKey, "password");
            Assert.True(model.PasswordInput.IsRequired);
            Assert.IsEmpty(model.PasswordInput.Value);
        }

        private static LogOnModel GetModel()
        {
            return new LogOnModel();
        }
    }
}