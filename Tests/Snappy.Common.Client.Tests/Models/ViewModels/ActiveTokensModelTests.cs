using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class ActiveTokensModelTests
    {
        [Test]
        public void ActiveTokensModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "active_tokens_title");
        }

        private static ActiveTokensModel GetModel()
        {
            return new ActiveTokensModel();
        }
    }
}