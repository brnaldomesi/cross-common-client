using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture()]
    class IntegrationCreateModelTests
    {
        [Test]
        public void IntegrationCreateModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "integration_create_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, "integration_name_required_error_message")]
        public void IntegrationCreateModel_Validates_AddsErrorMessages(string integrationName, string errorMessage)
        {
            var model = GetModel();
            model.IntegrationName = integrationName;

            Assert.False(model.IsValid());
            Assert.True(model.InputErrorMessages.Contains(errorMessage));
        }

        [Test]
        public void IntegrationCreateModel_has_IntegrationNameInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.IntegrationNameInput.Name, "IntegrationName");
            Assert.AreEqual(model.IntegrationNameInput.LabelKey, "integration_name");
            Assert.True(model.IntegrationNameInput.IsRequired);
            Assert.IsEmpty(model.IntegrationNameInput.Value);
        }

        [Test]
        public void IntegrationCreateModel_has_DescriptionInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.DescriptionInput.Name, "Description");
            Assert.AreEqual(model.DescriptionInput.LabelKey, "description");
            Assert.False(model.DescriptionInput.IsRequired);
            Assert.IsEmpty(model.DescriptionInput.Value);
        }

        private static IntegrationCreateModel GetModel()
        {
            return new IntegrationCreateModel();
        }
    }
}
