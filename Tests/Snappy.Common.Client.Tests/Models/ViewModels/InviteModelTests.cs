using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Client.Tests.Models.ViewModels.Base;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class InviteModelTests : BaseViewModelTest<InviteModel>
    {
        public InviteModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void InviteModel_title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "user_invite_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.STRING, TestDataHelper.STRING_1,
                  new[] { "email_required_error_massage" })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING, TestDataHelper.STRING_1,
                  new[] { "email_is_not_valid_error_message" })]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.EMPTY_STRING, TestDataHelper.STRING_1,
                  new[] { "first_name_required_error_massage" })]
        [TestCase(TestDataHelper.EMAIL, TestDataHelper.STRING, TestDataHelper.EMPTY_STRING,
                  new[] { "last_name_required_error_massage" })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.EMPTY_STRING, TestDataHelper.STRING_1,
                  new[] { "email_is_not_valid_error_message", "first_name_required_error_massage" })]
        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.STRING, TestDataHelper.EMPTY_STRING,
                  new[] { "email_required_error_massage", "last_name_required_error_massage" })]
        public void InviteModel_InputErrorMessages(string email, string firstName, string lastName, string[] errorMessage)
        {
            SystemUnderTest.Email = email;
            SystemUnderTest.FirstName = firstName;
            SystemUnderTest.LastName = lastName;

            AssertModelValidation(SystemUnderTest.IsValid());
            AssertInputErrorMessages(SystemUnderTest.InputErrorMessages, errorMessage);
        }

        [Test]
        public void InviteModel_EmailInputModel()
        {
            AssertInputModel(SystemUnderTest.EmailInput, "Email", "email", true);
        }

        [Test]
        public void InviteModel_FirstNameInputModel()
        {
            AssertInputModel(SystemUnderTest.FirstNameInput, "FirstName", "first_name", true);
        }

        [Test]
        public void InviteModel_LastNameInputModel()
        {
            AssertInputModel(SystemUnderTest.LastNameInput, "LastName", "last_name", true);
        }
    }
}
