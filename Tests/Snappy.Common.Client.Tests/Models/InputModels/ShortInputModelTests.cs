using NUnit.Framework;

using Snappy.Common.Client.Models.InputModels;

namespace Snappy.Common.Client.Tests.Models.InputModels
{
    [TestFixture]
    public class ShortInputModelTests
    {
        [TestCase("name", "label", true, "value")]
        [TestCase("name", "label", false, "value")]
        public void ShortInputModel(string name, string labelKey, bool isRequired, string value)
        {
            var model = new ShortInputModel(name, labelKey, isRequired, value);

            Assert.AreEqual(name, model.Name);
            Assert.AreEqual(labelKey, model.LabelKey);
            Assert.AreEqual(isRequired, model.IsRequired);
            Assert.AreEqual(value, model.Value);
        }
    }
}