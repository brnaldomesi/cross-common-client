using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Client.Tests.Models.ViewModels.Base;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class ResetPasswordModelTests : BaseViewModelTest<ResetPasswordModel>
    {
        public ResetPasswordModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void ResetPasswordModel_title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "reset_password_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD,
                  new[] { "password_required_error_message", "re_entered_password_does_not_match_error_message" })]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.EMPTY_STRING,
                  new[] { "re_entered_password_required_error_message", "re_entered_password_does_not_match_error_message" })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.PASSWORD,
                  new[] { "password_is_not_valid_error_message", "re_entered_password_does_not_match_error_message" })]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.STRING,
                  new[] { "re_entered_password_is_not_valid_error_message", "re_entered_password_does_not_match_error_message" })]
        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.STRING,
                  new[] { "password_required_error_message", "re_entered_password_does_not_match_error_message" })]
        public void ResetPasswordModel_InputErrorMessages(string password, string reEnterPassword, string[] errorMessage)
        {
            SystemUnderTest.Password = password;
            SystemUnderTest.ReEnterPassword = reEnterPassword;

            AssertModelValidation(SystemUnderTest.IsValid());
            AssertInputErrorMessages(SystemUnderTest.InputErrorMessages, errorMessage);
        }

        [Test]
        public void ResetPasswordModel_PasswordInputModel()
        {
            AssertInputModel(SystemUnderTest.PasswordInput, "Password", "password", true);

        }

        [Test]
        public void ResetPasswordModel_ReEnterPasswordInputModel()
        {
            AssertInputModel(SystemUnderTest.ReEnterPasswordInput, "ReEnterNewPassword", "re_enter_password", true);
        }
    }
}
