﻿using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    class ResetPasswordModelTests
    {
        [Test]
        public void ResetPasswordModel_has_title()
        {
            var model = GetModel();
            Assert.AreEqual(model.Title, "reset_password_title");
        }

        [TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.PASSWORD, "password_required_error_message")]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.EMPTY_STRING, "password_required_error_message")]
        [TestCase("asd", TestDataHelper.EMPTY_STRING, "password_is_not_valid_error_message")]
        [TestCase(TestDataHelper.PASSWORD, "asd", "password_is_not_valid_error_message")]
        [TestCase(TestDataHelper.PASSWORD, TestDataHelper.PASSWORD+"*", "re_entered_password_does_not_match_error_message")]
        public void ResetPasswordModel_Validates_AddsErrorMessages(string password,string reEnterPassword, string errorMessage)
        {
            var model = GetModel();
            model.Password = password;
            model.ReEnterPassword = reEnterPassword;

            Assert.False(model.IsValid());
            Assert.True(model.InputErrorMessages.Contains(errorMessage));
        }

        [Test]
        public void ResetPasswordModel_has_PasswordInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.PasswordInput.Name, "Password");
            Assert.AreEqual(model.PasswordInput.LabelKey, "password");
            Assert.True(model.PasswordInput.IsRequired);
            Assert.IsEmpty(model.PasswordInput.Value);
        }

        [Test]
        public void ResetPasswordModel_has_ReEnterPasswordInputModel()
        {
            var model = GetModel();
            Assert.AreEqual(model.ReEnterPasswordInput.Name, "ReEnterNewPassword");
            Assert.AreEqual(model.ReEnterPasswordInput.LabelKey, "re_enter_password");
            Assert.True(model.ReEnterPasswordInput.IsRequired);
            Assert.IsEmpty(model.ReEnterPasswordInput.Value);
        }

        private static ResetPasswordModel GetModel()
        {
            return new ResetPasswordModel();
        }
    }
}