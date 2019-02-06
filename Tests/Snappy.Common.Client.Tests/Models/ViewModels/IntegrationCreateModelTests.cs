using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Client.Tests.Models.ViewModels.Base;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture()]
    public class IntegrationCreateModelTests : BaseViewModelTest<IntegrationCreateModel>
    {
        public IntegrationCreateModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void IntegrationCreateModel_title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "integration_create_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, new[] { "integration_name_required_error_message" })]
        public void IntegrationCreateModel_InputErrorMessages(string integrationName, string[] errorMessage)
        {
            SystemUnderTest.IntegrationName = integrationName;

            AssertModelValidation(SystemUnderTest.IsValid());
            AssertInputErrorMessages(SystemUnderTest.InputErrorMessages, errorMessage);
        }

        [Test]
        public void IntegrationCreateModel_IntegrationNameInputModel()
        {
            AssertInputModel(SystemUnderTest.IntegrationNameInput, "IntegrationName", "integration_name", true);
        }

        [Test]
        public void IntegrationCreateModel_DescriptionInputModel()
        {
            AssertInputModel(SystemUnderTest.DescriptionInput, "Description", "description", false);
        }
    }
}
