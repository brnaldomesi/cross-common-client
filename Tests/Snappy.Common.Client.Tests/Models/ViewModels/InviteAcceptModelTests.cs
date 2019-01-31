using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class InviteAcceptModelTests
    {
        [Test]
        public void InviteAcceptModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "accept_invite_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.STRING_1, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD, new string[]
        {
            "first_name_required_error_message"
        })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD, new string[]
        {
            "last_name_required_error_message"
        })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD, new string[]
        {
            "new_password_required_error_message",
            "re_entered_password_does_not_match_error_message"
        })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.PASSWORD, TestDataHelper.EMPTY_STRING, new string[]
        {
            "re_enter_password_required_error_message",
            "re_enter_password_is_not_valid_error_message",
            "re_entered_password_does_not_match_error_message"
        })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.STRING, TestDataHelper.PASSWORD, new string[]
        {
            "new_password_is_not_valid_error_message",
            "re_entered_password_does_not_match_error_message"
        })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.PASSWORD, TestDataHelper.STRING, new string[]
        {
            "re_enter_password_is_not_valid_error_message",
            "re_entered_password_does_not_match_error_message"
        })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD_1, new string[]
        {
            "re_entered_password_does_not_match_error_message"
        })]
        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.EMPTY_STRING, TestDataHelper.STRING, TestDataHelper.PASSWORD, new string[]
        {
            "first_name_required_error_message",
            "last_name_required_error_message",
            "new_password_is_not_valid_error_message"
        })]
        public void InviteAcceptModel_Validates_InputErrorMessages(string firstName, string lastName, string newPassword,
                                                                   string reEnterNewPassword, string[] errorMessage)
        {
            var model = GetModel();
            model.FirstName = firstName;
            model.LastName = lastName;
            model.NewPassword = newPassword;
            model.ReEnterNewPassword = reEnterNewPassword;

            Assert.False(model.IsValid());
            foreach (var message in errorMessage)
            {
                Assert.True(model.InputErrorMessages.Contains(message));
            }
        }

        [Test]
        public void InviteAcceptModel_has_FirstNameInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.FirstNameInput.Name, "FirstName");
            Assert.AreEqual(model.FirstNameInput.LabelKey, "first_name");
            Assert.True(model.FirstNameInput.IsRequired);
            Assert.IsEmpty(model.FirstNameInput.Value);
        }

        [Test]
        public void InviteAcceptModel_has_LastNameInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.LastNameInput.Name, "LastName");
            Assert.AreEqual(model.LastNameInput.LabelKey, "last_name");
            Assert.True(model.LastNameInput.IsRequired);
            Assert.IsEmpty(model.LastNameInput.Value);
        }

        [Test]
        public void InviteAcceptModel_has_NewPasswordInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.NewPasswordInput.Name, "NewPassword");
            Assert.AreEqual(model.NewPasswordInput.LabelKey, "new_password");
            Assert.True(model.NewPasswordInput.IsRequired);
            Assert.IsEmpty(model.NewPasswordInput.Value);
        }

        [Test]
        public void InviteAcceptModel_has_ReEnterNewPasswordInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.ReEnterNewPasswordInput.Name, "ReEnterNewPassword");
            Assert.AreEqual(model.ReEnterNewPasswordInput.LabelKey, "re_enter_new_password");
            Assert.True(model.ReEnterNewPasswordInput.IsRequired);
            Assert.IsEmpty(model.ReEnterNewPasswordInput.Value);
        }

        private static InviteAcceptModel GetModel()
        {
            return new InviteAcceptModel();
        }
    }
}
