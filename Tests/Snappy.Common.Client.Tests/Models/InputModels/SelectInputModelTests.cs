using NUnit.Framework;

using Snappy.Common.Client.Models.InputModels;

namespace Snappy.Common.Client.Tests.Models.InputModels
{
    [TestFixture]
    public class SelectInputModelTests
    {
        [TestCase("name", "label", "dataUrl", "parent", true)]
        [TestCase("name", "label", "dataUrl", "parent", false)]
        public void SelectInputModel(string name, string labelKey, string dataUrl, string parent, bool isRequired)
        {
            var model = new SelectInputModel(name, labelKey, dataUrl, parent, isRequired);

            Assert.AreEqual(name, model.Name);
            Assert.AreEqual(labelKey, model.LabelKey);
            Assert.AreEqual(dataUrl, model.DataUrl);
            Assert.AreEqual(parent, model.Parent);
            Assert.AreEqual(isRequired, model.IsRequired);
        }
    }
}