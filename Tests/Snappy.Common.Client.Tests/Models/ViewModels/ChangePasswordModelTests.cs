using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    class ChangePasswordModelTests
    {
        [Test]
        public void ChangePasswordModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "user_change_password_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD_1, TestDataHelper.PASSWORD_1, new string[]
        {
            "old_password_required_error_message"
        })]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD_1, new string[]
        {
            "new_password_required_error_message"
        })]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.PASSWORD_1, TestDataHelper.EMPTY_STRING, new string[]
        {
            "re_entered_password_required_error_message"
        })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.PASSWORD_1, TestDataHelper.PASSWORD_1, new string[]
        {
            "old_password_is_not_valid_error_message"
        })]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.STRING, TestDataHelper.STRING, new string[]
        {
            "new_password_is_not_valid_error_message"
        })]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.PASSWORD_1, TestDataHelper.STRING, new string[]
        {
            "re_entered_password_is_not_valid_error_message",
            "re_entered_password_does_not_match_error_message"
        })]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD, new string[]
        {
            "new_password_can_not_same_as_old_password_error_message"
        })]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.PASSWORD_1, TestDataHelper.PASSWORD_2, new string[]
        {
            "re_entered_password_does_not_match_error_message"
        })]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.PASSWORD, TestDataHelper.EMPTY_STRING, new string[]
        {
            "re_entered_password_is_not_valid_error_message",
            "re_entered_password_does_not_match_error_message"
        })]
        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.EMPTY_STRING, TestDataHelper.EMPTY_STRING, new string[]
        {
            "old_password_required_error_message",
            "new_password_required_error_message",
            "re_entered_password_required_error_message"
        })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING, TestDataHelper.STRING_1, new string[]
        {
            "old_password_is_not_valid_error_message",
            "new_password_is_not_valid_error_message",
            "new_password_can_not_same_as_old_password_error_message",
            "re_entered_password_does_not_match_error_message"
        })]
        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD_1, TestDataHelper.PASSWORD, new string[]
        {
            "old_password_required_error_message",
            "re_entered_password_does_not_match_error_message"
        })]
        public void ChangePasswordModel_Validates_InputErrorMessages(string oldPassword, string newPassword, string reEnteredPassword,
                                                                string[] errorMessage)
        {
            var model = GetModel();
            model.OldPassword = oldPassword;
            model.NewPassword = newPassword;
            model.ReEnterNewPassword = reEnteredPassword;

            Assert.False(model.IsValid());
            foreach (var message in errorMessage)
            {
                Assert.True(model.InputErrorMessages.Contains(message));
            }
        }

        [Test]
        public void ChangePasswordModel_has_OldPasswordInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.OldPasswordInput.Name, "OldPassword");
            Assert.AreEqual(model.OldPasswordInput.LabelKey, "old_password");
            Assert.True(model.OldPasswordInput.IsRequired);
            Assert.IsEmpty(model.OldPasswordInput.Value);
        }

        [Test]
        public void ChangePasswordModel_has_NewPasswordInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.NewPasswordInput.Name, "NewPassword");
            Assert.AreEqual(model.NewPasswordInput.LabelKey, "new_password");
            Assert.True(model.NewPasswordInput.IsRequired);
            Assert.IsEmpty(model.NewPasswordInput.Value);
        }

        [Test]
        public void ChangePasswordModel_has_ReEnterNewPasswordInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.ReEnterNewPasswordInput.Name, "ReEnterNewPassword");
            Assert.AreEqual(model.ReEnterNewPasswordInput.LabelKey, "re_enter_new_password");
            Assert.True(model.ReEnterNewPasswordInput.IsRequired);
            Assert.IsEmpty(model.ReEnterNewPasswordInput.Value);
        }

        private static ChangePasswordModel GetModel()
        {
            return new ChangePasswordModel();
        }
    }
}
