using NUnit.Framework;

using Snappy.Common.Client.Models.InputModels;

namespace Snappy.Common.Client.Tests.Models.InputModels
{
    [TestFixture]
    public class EmailInputModelTest
    {
        [TestCase("Email", "the_email", true)]
        [TestCase("Email", "the_email", false)]
        public void EmailInputModel(string name, string labelKey, bool isRequired)
        {
            var model = new EmailInputModel(name, labelKey, isRequired);

            Assert.AreEqual(name, model.Name);
            Assert.AreEqual(labelKey, model.LabelKey);
            Assert.AreEqual(isRequired, model.IsRequired);
        }
    }
}