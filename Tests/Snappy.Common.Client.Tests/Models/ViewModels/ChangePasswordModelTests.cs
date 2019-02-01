using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Client.Tests.Models.ViewModels.Base;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class ChangePasswordModelTests : BaseViewModelTest<ChangePasswordModel>
    {
        public ChangePasswordModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void ChangePasswordModel_title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "user_change_password_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD_1, TestDataHelper.PASSWORD_1,
                  new[] { "old_password_required_error_message" })]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD_1,
                  new[] { "new_password_required_error_message" })]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.PASSWORD_1, TestDataHelper.EMPTY_STRING,
                  new[] { "re_entered_password_required_error_message" })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.PASSWORD_1, TestDataHelper.PASSWORD_1,
                  new[] { "old_password_is_not_valid_error_message" })]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.STRING, TestDataHelper.STRING,
                  new[] { "new_password_is_not_valid_error_message" })]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.PASSWORD_1, TestDataHelper.STRING,
                  new[] { "re_entered_password_is_not_valid_error_message", "re_entered_password_does_not_match_error_message" })]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD,
                  new[] { "new_password_can_not_same_as_old_password_error_message" })]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.PASSWORD_1, TestDataHelper.PASSWORD_2,
                  new[] { "re_entered_password_does_not_match_error_message" })]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.PASSWORD, TestDataHelper.EMPTY_STRING,
                  new[] { "re_entered_password_is_not_valid_error_message", "re_entered_password_does_not_match_error_message" })]
        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.EMPTY_STRING, TestDataHelper.EMPTY_STRING,
                  new[] { "old_password_required_error_message", "new_password_required_error_message",
                          "re_entered_password_required_error_message" })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING, TestDataHelper.STRING_1,
                  new[] { "old_password_is_not_valid_error_message", "new_password_is_not_valid_error_message",
                          "new_password_can_not_same_as_old_password_error_message", "re_entered_password_does_not_match_error_message" })]
        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD_1, TestDataHelper.PASSWORD,
                  new[] { "old_password_required_error_message", "re_entered_password_does_not_match_error_message" })]
        public void ChangePasswordModel_InputErrorMessages(string oldPassword, string newPassword, string reEnteredPassword,
                                                           string[] errorMessage)
        {
            SystemUnderTest.OldPassword = oldPassword;
            SystemUnderTest.NewPassword = newPassword;
            SystemUnderTest.ReEnterNewPassword = reEnteredPassword;

            AssertModelValidation(SystemUnderTest.IsValid());
            AssertInputErrorMessages(SystemUnderTest.InputErrorMessages, errorMessage);
        }

        [Test]
        public void ChangePasswordModel_OldPasswordInputModel()
        {
            AssertInputModel(SystemUnderTest.OldPasswordInput, "OldPassword", "old_password", true);
        }

        [Test]
        public void ChangePasswordModel_NewPasswordInputModel()
        {
            AssertInputModel(SystemUnderTest.NewPasswordInput, "NewPassword", "new_password", true);
        }

        [Test]
        public void ChangePasswordModel_ReEnterNewPasswordInputModel()
        {
            AssertInputModel(SystemUnderTest.ReEnterNewPasswordInput, "ReEnterNewPassword", "re_enter_new_password",
                                     true);
        }
    }
}
