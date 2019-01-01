using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;

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

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD, "email_required_error_message")]
        [TestCase("asd", TestDataHelper.PASSWORD, "email_is_not_valid_error_message")]
        [TestCase(TestDataHelper.EMAIL, "asd", "password_is_not_valid_error_message")]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.EMPTY_STRING, "password_required_error_message")]
        public void LogOnModel_Validates_AddsErrorMessages(string email, string password, string errorMessage)
        {
            var model = GetModel();
            model.Email = email;
            model.Password = password;

            Assert.False(model.IsValid());
            Assert.True(model.InputErrorMessages.Contains(errorMessage));
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