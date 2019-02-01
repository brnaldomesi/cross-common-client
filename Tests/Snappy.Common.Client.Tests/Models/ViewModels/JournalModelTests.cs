using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class JournalModelTests
    {
        [Test]
        public void JournalModel_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "journal_title");
        }

        private static JournalModel GetModel()
        {
            return new JournalModel();
        }
    }
}