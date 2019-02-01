using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Client.Tests.Models.ViewModels.Base;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class InviteAcceptModelTests : BaseViewModelTest<InviteAcceptModel>
    {
        public InviteAcceptModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void InviteAcceptModel_title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "accept_invite_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.STRING_1, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD,
                  new[] { "first_name_required_error_message" })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD,
                  new[] { "last_name_required_error_message" })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD,
                  new[] { "new_password_required_error_message", "re_entered_password_does_not_match_error_message" })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.PASSWORD, TestDataHelper.EMPTY_STRING,
                  new[] { "re_enter_password_required_error_message","re_enter_password_is_not_valid_error_message",
                          "re_entered_password_does_not_match_error_message"})]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.STRING, TestDataHelper.PASSWORD,
                  new[] { "new_password_is_not_valid_error_message",
                          "re_entered_password_does_not_match_error_message" })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.PASSWORD, TestDataHelper.STRING,
                  new[] { "re_enter_password_is_not_valid_error_message", "re_entered_password_does_not_match_error_message" })]
        [TestCase(TestDataHelper.STRING, TestDataHelper.STRING_1, TestDataHelper.PASSWORD, TestDataHelper.PASSWORD_1,
                  new[] { "re_entered_password_does_not_match_error_message" })]
        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.EMPTY_STRING, TestDataHelper.STRING, TestDataHelper.PASSWORD,
                  new[] { "first_name_required_error_message", "last_name_required_error_message",
                          "new_password_is_not_valid_error_message" })]
        public void InviteAcceptModel_InputErrorMessages(string firstName, string lastName, string newPassword,
                                                                   string reEnterNewPassword, string[] errorMessage)
        {
            SystemUnderTest.FirstName = firstName;
            SystemUnderTest.LastName = lastName;
            SystemUnderTest.NewPassword = newPassword;
            SystemUnderTest.ReEnterNewPassword = reEnterNewPassword;

            AssertModelValidation(SystemUnderTest.IsValid());
            AssertInputErrorMessages(SystemUnderTest.InputErrorMessages, errorMessage);
        }

        [Test]
        public void InviteAcceptModel_FirstNameInputModel()
        {
            AssertInputModel(SystemUnderTest.FirstNameInput, "FirstName", "first_name", true);
        }

        [Test]
        public void InviteAcceptModel_LastNameInputModel()
        {
            AssertInputModel(SystemUnderTest.LastNameInput, "LastName", "last_name", true);
        }

        [Test]
        public void InviteAcceptModel_NewPasswordInputModel()
        {
            AssertInputModel(SystemUnderTest.NewPasswordInput, "NewPassword", "new_password", true);
        }

        [Test]
        public void InviteAcceptModel_ReEnterNewPasswordInputModel()
        {
            AssertInputModel(SystemUnderTest.ReEnterNewPasswordInput, "ReEnterNewPassword", "re_enter_new_password",
                                     true);
        }
    }
}
