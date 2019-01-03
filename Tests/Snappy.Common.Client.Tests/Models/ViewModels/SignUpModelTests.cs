using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    class SignUpModelTests
    {
        [Test]
        public void SignUpModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "sign_up_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, TestDataHelper.NAME, TestDataHelper.PASSWORD, true, "email_required_error_message")]
        [TestCase("asd", TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, TestDataHelper.NAME, TestDataHelper.PASSWORD, true, "email_is_not_valid_error_message")]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.EMPTY_STRING, TestDataHelper.LASTNAME, TestDataHelper.NAME, TestDataHelper.PASSWORD, true, "first_name_required_error_message")]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.FIRSTNAME, TestDataHelper.EMPTY_STRING, TestDataHelper.NAME, TestDataHelper.PASSWORD, true, "last_name_required_error_message")]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD, true, "organization_name_required_error_message")]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, TestDataHelper.NAME, TestDataHelper.EMPTY_STRING, true, "password_required_error_message")]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, TestDataHelper.NAME, "asd", true, "password_is_not_valid_error_message")]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME, TestDataHelper.NAME, TestDataHelper.PASSWORD, false, "you_must_accept_terms_error_message")]
        public void SignUpModel_Validates_AddsErrorMessages(string email, string firstName, string lastName,
                                                           string organizationName, string password, bool isTermsAccepted, string errorMessage)
        {
            var model = GetModel();
            model.Email = email;
            model.FirstName = firstName;
            model.LastName = lastName;
            model.OrganizationName = organizationName;
            model.Password = password;
            model.IsTermsAccepted = isTermsAccepted;

            Assert.False(model.IsValid());
            Assert.True(model.InputErrorMessages.Contains(errorMessage));
        }

        [Test]
        public void SignUpModel_has_EmailInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.EmailInput.Name, "Email");
            Assert.AreEqual(model.EmailInput.LabelKey, "email");
            Assert.True(model.EmailInput.IsRequired);
            Assert.IsEmpty(model.EmailInput.Value);
        }

        [Test]
        public void SignUpModel_has_FirstNameInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.FirstNameInput.Name, "FirstName");
            Assert.AreEqual(model.FirstNameInput.LabelKey, "first_name");
            Assert.True(model.FirstNameInput.IsRequired);
            Assert.IsEmpty(model.FirstNameInput.Value);
        }

        [Test]
        public void SignUpModel_has_LastNameInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.LastNameInput.Name, "LastName");
            Assert.AreEqual(model.LastNameInput.LabelKey, "last_name");
            Assert.True(model.LastNameInput.IsRequired);
            Assert.IsEmpty(model.LastNameInput.Value);
        }

        [Test]
        public void SignUpModel_has_OrganizationNameInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.OrganizationNameInput.Name, "OrganizationName");
            Assert.AreEqual(model.OrganizationNameInput.LabelKey, "organization_name");
            Assert.True(model.OrganizationNameInput.IsRequired);
            Assert.IsEmpty(model.OrganizationNameInput.Value);
        }

        [Test]
        public void SignUpModel_has_PasswordInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.PasswordInput.Name, "Password");
            Assert.AreEqual(model.PasswordInput.LabelKey, "password");
            Assert.True(model.PasswordInput.IsRequired);
            Assert.IsEmpty(model.PasswordInput.Value);
        }

        [Test]
        public void SignUpModel_has_IsTermsAcceptedInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.IsTermsAcceptedInput.Name, "IsTermsAccepted");
            Assert.AreEqual(model.IsTermsAcceptedInput.LabelKey, "accept_terms");
            Assert.True(model.IsTermsAcceptedInput.IsRequired);
            Assert.False(model.IsTermsAcceptedInput.Value);
        }

        private static SignUpModel GetModel()
        {
            return new SignUpModel();
        }
    }
}
