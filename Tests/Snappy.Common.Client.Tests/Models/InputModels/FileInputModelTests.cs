using NUnit.Framework;
using Snappy.Common.Client.Models.InputModels;

namespace Snappy.Common.Client.Tests.Models.InputModels
{
    [TestFixture]
    public class FileInputModelTests
    {
        [TestCase("name", "label", true, true)]
        [TestCase("name", "label", false, false)]
        public void FileInputModel(string name, string labelKey, bool isRequired, bool isMultiple)
        {
            var model = new FileInputModel(name, labelKey, isRequired, isMultiple);

            Assert.AreEqual(name, model.Name);
            Assert.AreEqual(labelKey, model.LabelKey);
            Assert.AreEqual(isRequired, model.IsRequired);
            Assert.AreEqual(isMultiple, model.IsMultiple);
        }
    }
}