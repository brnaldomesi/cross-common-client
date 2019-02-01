using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Client.Tests.Models.ViewModels.Base;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class UserDetailBaseModelTests : BaseViewModelTest<UserDetailBaseModel>
    {
        public UserDetailBaseModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void UserDetailBaseModel_title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "user_detail_title");
        }

        [Test]
        public void UserDetailBaseModel_IsActiveInput()
        {
            AssertCheckBoxInputModel(SystemUnderTest.IsActiveInput, "IsActive", "is_active", false);
        }
    }
}