using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class UserDetailBaseModelTests
    {
        [Test]
        public void UserDetailBaseModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "user_detail_title");
        }

        [Test]
        public void UserDetailBaseModel_has_IsActiveInput()
        {
            var model = GetModel();
            Assert.AreEqual(model.IsActiveInput.Name, "IsActive");
            Assert.AreEqual(model.IsActiveInput.LabelKey, "is_active");
            Assert.False(model.IsActiveInput.IsRequired);
            Assert.False(model.IsActiveInput.IsReadOnly);
        }

        private static UserDetailBaseModel GetModel()
        {
            return new UserDetailBaseModel();
        }
    }
}