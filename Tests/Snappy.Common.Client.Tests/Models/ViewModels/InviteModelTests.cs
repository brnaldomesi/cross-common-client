using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    class InviteModelTests
    {
        [Test]
        public void InviteModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "invite_tittle");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, "email_required_error_massage")]
        [TestCase("asd", TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, "email_is_not_valid_error_message")]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.EMPTY_STRING, TestDataHelper.LASTNAME, "first_name_required_error_massage")]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.FIRSTNAME, TestDataHelper.EMPTY_STRING, "last_name_required_error_massage")]
        public void InviteModel_Validates_AddsErrorMessages(string email, string firstName, string lastName, string errorMessage)
        {
            var model = GetModel();
            model.Email = email;
            model.FirstName = firstName;
            model.LastName = lastName;

            Assert.False(model.IsValid());
            Assert.True(model.InputErrorMessages.Contains(errorMessage));
        }

        [Test]
        public void InviteModel_has_EmailInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.EmailInput.Name, "Email");
            Assert.AreEqual(model.EmailInput.LabelKey, "email");
            Assert.True(model.EmailInput.IsRequired);
            Assert.IsEmpty(model.EmailInput.Value);
        }

        [Test]
        public void InviteModel_has_FirstNameInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.FirstNameInput.Name, "FirstName");
            Assert.AreEqual(model.FirstNameInput.LabelKey, "first_name");
            Assert.True(model.FirstNameInput.IsRequired);
            Assert.IsEmpty(model.FirstNameInput.Value);
        }

        [Test]
        public void InviteModel_has_LastNameInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.LastNameInput.Name, "LastName");
            Assert.AreEqual(model.LastNameInput.LabelKey, "last_name");
            Assert.True(model.LastNameInput.IsRequired);
            Assert.IsEmpty(model.LastNameInput.Value);
        }

        private static InviteModel GetModel()
        {
            return new InviteModel();
        }
    }
}
