using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class IntegrationDetailModelTests
    {
        [Test]
        public void IntegrationDetailModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "integration_detail_title");
        }

        private static IntegrationDetailModel GetModel()
        {
            return new IntegrationDetailModel();
        }
    }
}