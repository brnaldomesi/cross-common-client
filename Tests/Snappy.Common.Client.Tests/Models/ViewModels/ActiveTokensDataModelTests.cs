using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class ActiveTokensDataModelTests
    {
        [Test]
        public void ActiveTokensDataModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "active_tokens_table_title");
        }

        private static ActiveTokensDataModel GetModel()
        {
            return new ActiveTokensDataModel();
        }
    }
}