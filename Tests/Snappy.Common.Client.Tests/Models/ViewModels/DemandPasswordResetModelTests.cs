using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Client.Tests.Models.ViewModels.Base;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    class DemandPasswordResetModelTests : BaseViewModelTest<DemandPasswordResetModel>
    {
        public DemandPasswordResetModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void DemandPasswordResetModel_title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "demand_password_reset_title");
        }

        [TestCase(TestDataHelper.STRING, new[] { "email_is_not_valid_error_message" })]
        [TestCase(TestDataHelper.EMPTY_STRING, new[] { "email_required_error_message" })]
        public void DemandPasswordResetModel_InputErrorMessages(string email, string[] errorMessage)
        {
            SystemUnderTest.Email = email;

            AssertModelValidation(SystemUnderTest.IsValid());
            AssertInputErrorMessages(SystemUnderTest.InputErrorMessages, errorMessage);
        }

        [Test]
        public void DemandPasswordResetModel_EmailInputModel()
        {
            AssertInputModel(SystemUnderTest.EmailInput, "Email", "email", true);
        }
    }
}
