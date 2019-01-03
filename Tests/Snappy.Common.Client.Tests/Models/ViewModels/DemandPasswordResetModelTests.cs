using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    class DemandPasswordResetModelTests
    {
        [Test]
        public void DemandPasswordResetModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "demand_password_reset_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, "email_required_error_message")]
        [TestCase("asd", "email_is_not_valid_error_message")]
        public void DemandPasswordResetModel_Validates_AddsErrorMessages(string email, string errorMessage)
        {
            var model = GetModel();
            model.Email = email;

            Assert.False(model.IsValid());
            Assert.True(model.InputErrorMessages.Contains(errorMessage));
        }

        [Test]
        public void DemandPasswordResetModel_has_EmailInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.EmailInput.Name, "Email");
            Assert.AreEqual(model.EmailInput.LabelKey, "email");
            Assert.True(model.EmailInput.IsRequired);
            Assert.IsEmpty(model.EmailInput.Value);
        }

        private static DemandPasswordResetModel GetModel()
        {
            return new DemandPasswordResetModel();
        }
    }
}
