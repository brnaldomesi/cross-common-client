using NUnit.Framework;

using Snappy.Common.Client.Tests.Models.ViewModels.Base;
using Snappy.Common.Helpers;
using Snappy.Service.Common.Client.Models.ViewModels.User;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class SignUpModelTests : BaseViewModelTest<SignUpModel>
    {
        public SignUpModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void SignUpModel_Title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "sign_up_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.STRING, TestDataHelper.STRING_1,
                  TestDataHelper.STRING_3, TestDataHelper.PASSWORD, TestDataHelper.BOOL_TRUE,
                  new[] { "email_required_error_message" })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING, TestDataHelper.STRING_1,
                  TestDataHelper.STRING_3, TestDataHelper.PASSWORD, TestDataHelper.BOOL_TRUE,
                  new[] { "email_is_not_valid_error_message" })]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.EMPTY_STRING, TestDataHelper.STRING_1,
                  TestDataHelper.STRING_3, TestDataHelper.PASSWORD, TestDataHelper.BOOL_TRUE,
                  new[] { "first_name_required_error_message" })]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.STRING, TestDataHelper.EMPTY_STRING,
                  TestDataHelper.STRING_3, TestDataHelper.PASSWORD, TestDataHelper.BOOL_TRUE,
                  new[] { "last_name_required_error_message" })]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.STRING, TestDataHelper.STRING_1,
                  TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD, TestDataHelper.BOOL_TRUE,
                  new[] { "organization_name_required_error_message" })]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.STRING, TestDataHelper.STRING_1,
                  TestDataHelper.STRING_3, TestDataHelper.EMPTY_STRING, TestDataHelper.BOOL_TRUE,
                  new[] { "password_required_error_message" })]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.STRING, TestDataHelper.STRING_1,
                  TestDataHelper.STRING_3, TestDataHelper.STRING, TestDataHelper.BOOL_TRUE,
                  new[] { "password_is_not_valid_error_message" })]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.STRING, TestDataHelper.STRING_1,
                  TestDataHelper.STRING_3, TestDataHelper.PASSWORD, TestDataHelper.BOOL_FALSE,
                  new[] { "you_must_accept_terms_error_message" })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING, TestDataHelper.STRING_1,
                  TestDataHelper.STRING_3, TestDataHelper.PASSWORD, TestDataHelper.BOOL_FALSE,
                  new[] { "email_is_not_valid_error_message", "you_must_accept_terms_error_message" })]
        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.STRING, TestDataHelper.STRING_1,
                  TestDataHelper.STRING_3, TestDataHelper.STRING, TestDataHelper.BOOL_TRUE,
                  new[] { "email_required_error_message", "password_is_not_valid_error_message" })]
        public void SignUpModel_InputErrorMessages(string email, string firstName, string lastName,
                                                   string organizationName, string password, bool isTermsAccepted,
                                                   string[] errorMessage)
        {
            SystemUnderTest.Email = email;
            SystemUnderTest.FirstName = firstName;
            SystemUnderTest.LastName = lastName;
            SystemUnderTest.OrganizationName = organizationName;
            SystemUnderTest.Password = password;
            SystemUnderTest.IsTermsAccepted = isTermsAccepted;

            AssertModelValidation(SystemUnderTest.IsValid());
            AssertInputErrorMessages(SystemUnderTest.InputErrorMessages, errorMessage);
        }

        [Test]
        public void SignUpModel_EmailInputModel()
        {
            AssertInputModel((InputModel) SystemUnderTest.EmailInput, "Email", "email", true);
        }

        [Test]
        public void SignUpModel_FirstNameInputModel()
        {
            AssertInputModel(SystemUnderTest.FirstNameInput, "FirstName", "first_name", true);
        }

        [Test]
        public void SignUpModel_LastNameInputModel()
        {
            AssertInputModel(SystemUnderTest.LastNameInput, "LastName", "last_name", true);
        }

        [Test]
        public void SignUpModel_OrganizationNameInputModel()
        {
            AssertInputModel(SystemUnderTest.OrganizationNameInput, "OrganizationName", "organization_name", true);
        }

        [Test]
        public void SignUpModel_PasswordInputModel()
        {
            AssertInputModel(SystemUnderTest.PasswordInput, "Password", "password", true);
        }

        [Test]
        public void SignUpModel_IsTermsAcceptedInputModel()
        {
            AssertCheckBoxInputModel(SystemUnderTest.IsTermsAcceptedInput, "IsTermsAccepted", "is_term_accepted", true);
        }
    }
}
