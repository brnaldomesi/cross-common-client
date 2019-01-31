using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class IntegrationEditBaseModelTests
    {
        [Test]
        public void IntegrationEditBaseModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "integration_edit_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, new string[]
        {
            "integration_name_required_error_message"
        })]
        public void IntegrationEditBaseModel_Validates_InputErrorMessages(string integrationName, string[] errorMessage)
        {
            var model = GetModel();
            model.IntegrationName = integrationName;

            Assert.False(model.IsValid());
            foreach (var message in errorMessage)
            {
                Assert.True(model.InputErrorMessages.Contains(message));
            }
        }

        [Test]
        public void IntegrationEditBaseModel_has_IntegrationNameInput()
        {
            var model = GetModel();
            Assert.AreEqual(model.IntegrationNameInput.Name, "IntegrationName");
            Assert.AreEqual(model.IntegrationNameInput.LabelKey, "integration_name");
            Assert.True(model.IntegrationNameInput.IsRequired);
        }

        [Test]
        public void IntegrationEditBaseModel_has_DescriptionInput()
        {
            var model = GetModel();
            Assert.AreEqual(model.DescriptionInput.Name, "Description");
            Assert.AreEqual(model.DescriptionInput.LabelKey, "description");
            Assert.False(model.DescriptionInput.IsRequired);
        }

        private static IntegrationEditBaseModel GetModel()
        {
            return new IntegrationEditBaseModel();
        }
    }
}