using NUnit.Framework;

using Snappy.Common.Client.Models.InputModels;

namespace Snappy.Common.Client.Tests.Models.InputModels
{
    [TestFixture]
    public class CheckboxInputModelTests
    {
        [TestCase("name", "label", true, true, true)]
        [TestCase("name", "label", false, true, false)]
        [TestCase("name", "label", false, false, false)]
        public void CheckboxInputModel(string name, string labelKey, bool isRequired, bool isReadOnly, bool value)
        {
            var model = new CheckboxInputModel(name, labelKey, isRequired, isReadOnly, value);

            Assert.AreEqual(name, model.Name);
            Assert.AreEqual(labelKey, model.LabelKey);
            Assert.AreEqual(isRequired, model.IsRequired);
            Assert.AreEqual(value, model.Value);
        }
    }
}