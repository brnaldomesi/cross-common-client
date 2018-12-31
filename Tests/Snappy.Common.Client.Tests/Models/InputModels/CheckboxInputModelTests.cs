using NUnit.Framework;

using Snappy.Common.Client.Models.InputModels;

namespace Snappy.Common.Client.Tests.Models.InputModels
{
    [TestFixture]
    public class CheckboxInputModelTests
    {
        [TestCase("name", "label", true, true)]
        [TestCase("name", "label", false, false)]
        public void CheckboxInputModel(string name, string labelKey, bool isRequired, bool value)
        {
            var model = new CheckboxInputModel(name, labelKey, isRequired, value);

            Assert.AreEqual(name, model.Name);
            Assert.AreEqual(labelKey, model.LabelKey);
            Assert.AreEqual(isRequired, model.IsRequired);
            Assert.AreEqual(value, model.Value);
        }
    }
}