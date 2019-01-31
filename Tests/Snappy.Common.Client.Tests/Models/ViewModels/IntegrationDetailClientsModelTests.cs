using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class IntegrationDetailClientsModelTests
    {
        [Test]
        public void IntegrationDetailClientsModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "integration_clients_title");
        }

        private static IntegrationDetailClientsModel GetModel()
        {
            return new IntegrationDetailClientsModel();
        }
    }
}