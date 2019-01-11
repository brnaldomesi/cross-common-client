using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;

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

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.LASTNAME, TestDataHelper.PASSWORD,TestDataHelper.PASSWORD, "first_name_required_error_message")]
        [TestCase(TestDataHelper.FIRSTNAME, TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD,TestDataHelper.PASSWORD, "last_name_required_error_message")]
        [TestCase(TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, TestDataHelper.EMPTY_STRING,TestDataHelper.PASSWORD, "password_required_error_message")]
        [TestCase(TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, TestDataHelper.PASSWORD,TestDataHelper.EMPTY_STRING, "password_required_error_message")]
        [TestCase(TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, "asd",TestDataHelper.PASSWORD, "password_is_not_valid_error_message")]
        [TestCase(TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, TestDataHelper.PASSWORD,"asd", "password_is_not_valid_error_message")]
        [TestCase(TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, TestDataHelper.PASSWORD,"asd", "re_entered_password_does_not_match_error_message")]
        public void InviteAcceptModel_Validates_AddsErrorMessages(string firstName, string lastName, string newPassword, string reEnterNewPassword,string errorMessage)
        {
            var model = GetModel();
            model.FirstName = firstName;
            model.LastName = lastName;
            model.NewPassword = newPassword;
            model.ReEnterNewPassword = reEnterNewPassword;

            Assert.False(model.IsValid());
            Assert.True(model.InputErrorMessages.Contains(errorMessage));
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
