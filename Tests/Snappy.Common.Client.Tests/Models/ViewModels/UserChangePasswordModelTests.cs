using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    class UserChangePasswordModelTests
    {
        [Test]
        public void UserChangePasswordModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "user_change_password_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD, "password_required_error_message")]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD, "password_required_error_message")]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD, "new_password_can_not_same_as_old_password_error_message")]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.PASSWORD+"*", TestDataHelper.PASSWORD, "re_entered_password_does_not_match_error_message")]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.PASSWORD+"*", TestDataHelper.EMPTY_STRING, "password_required_error_message")]
        [TestCase("asd", TestDataHelper.PASSWORD, TestDataHelper.PASSWORD, "password_is_not_valid_error_message")]
        [TestCase(TestDataHelper.PASSWORD, "asd", TestDataHelper.PASSWORD+"*", "password_is_not_valid_error_message")]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.PASSWORD, "asd", "password_is_not_valid_error_message")]
        public void UserChangePasswordModel_Validates_AddsErrorMessages(string oldPassword, string newPassword, string reEnterNewPassword, string errorMessage)
        {
            var model = GetModel();
            model.OldPassword = oldPassword;
            model.NewPassword = newPassword;
            model.ReEnterNewPassword = reEnterNewPassword;

            Assert.False(model.IsValid());
            Assert.True(model.InputErrorMessages.Contains(errorMessage));
        }

        [Test]
        public void UserChangePasswordModel_has_OldPasswordInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.OldPasswordInput.Name, "OldPassword");
            Assert.AreEqual(model.OldPasswordInput.LabelKey, "old_password");
            Assert.True(model.OldPasswordInput.IsRequired);
            Assert.IsEmpty(model.OldPasswordInput.Value);
        }

        [Test]
        public void UserChangePasswordModel_has_NewPasswordInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.NewPasswordInput.Name, "NewPassword");
            Assert.AreEqual(model.NewPasswordInput.LabelKey, "new_password");
            Assert.True(model.NewPasswordInput.IsRequired);
            Assert.IsEmpty(model.NewPasswordInput.Value);
        }

        [Test]
        public void UserChangePasswordModel_has_ReEnterNewPasswordInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.ReEnterNewPasswordInput.Name, "ReEnterNewPassword");
            Assert.AreEqual(model.ReEnterNewPasswordInput.LabelKey, "re_enter_new_password");
            Assert.True(model.ReEnterNewPasswordInput.IsRequired);
            Assert.IsEmpty(model.ReEnterNewPasswordInput.Value);
        }

        private static UserChangePasswordModel GetModel()
        {
            return new UserChangePasswordModel();
        }
    }
}
