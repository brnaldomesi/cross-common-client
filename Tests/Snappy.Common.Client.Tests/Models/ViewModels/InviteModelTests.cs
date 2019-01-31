using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    class InviteModelTests
    {
        [Test]
        public void InviteModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "invite_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.STRING, TestDataHelper.STRING_1, new string[]
        {
            "email_required_error_massage"
        })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING, TestDataHelper.STRING_1, new string[]
        {
            "email_is_not_valid_error_message"
        })]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.EMPTY_STRING, TestDataHelper.STRING_1, new string[]
        {
            "first_name_required_error_massage"
        })]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.STRING, TestDataHelper.EMPTY_STRING, new string[]
        {
            "last_name_required_error_massage"
        })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.EMPTY_STRING, TestDataHelper.STRING_1, new string[]
        {
            "email_is_not_valid_error_message",
            "first_name_required_error_massage"
        })]
        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.STRING, TestDataHelper.EMPTY_STRING, new string[]
        {
            "email_required_error_massage",
            "last_name_required_error_massage"
        })]
        public void InviteModel_Validates_AddsErrorMessages(string email, string firstName, string lastName, string[] errorMessage)
        {
            var model = GetModel();
            model.Email = email;
            model.FirstName = firstName;
            model.LastName = lastName;

            Assert.False(model.IsValid());
            foreach (var message in errorMessage)
            {
                Assert.True(model.InputErrorMessages.Contains(message));
            }
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
