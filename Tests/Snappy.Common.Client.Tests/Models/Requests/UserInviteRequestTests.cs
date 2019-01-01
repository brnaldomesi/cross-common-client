using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests;

namespace Snappy.Common.Client.Tests.Models.Requests
{
    [TestFixture]
    class UserInviteRequestTests
    {
        [Test]
        public void UserInviteRequest_Constructor()
        {
            var request = new UserInviteRequest(TestDataHelper.CURRENTUSERID, TestDataHelper.EMAIL, TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME);
            Assert.AreEqual(TestDataHelper.CURRENTUSERID, request.CurrentUserId);
            Assert.AreEqual(TestDataHelper.EMAIL, request.Email);
            Assert.AreEqual(TestDataHelper.FIRSTNAME, request.FirstName);
            Assert.AreEqual(TestDataHelper.LASTNAME, request.LastName);
        }

        [TestCase(TestDataHelper.CURRENTUSERID, TestDataHelper.EMPTYSTRING, TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME)]
        [TestCase(TestDataHelper.CURRENTUSERID, TestDataHelper.EMAIL, TestDataHelper.EMPTYSTRING, TestDataHelper.LASTNAME)]
        [TestCase(TestDataHelper.CURRENTUSERID, TestDataHelper.EMAIL, TestDataHelper.FIRSTNAME, TestDataHelper.EMPTYSTRING)]
        public void UserInviteRequest_Argument_Validations(int currentUserId, string email, string firstName, string lastName)
        {
            Assert.Throws<ArgumentException>(() => { new UserInviteRequest(currentUserId, email, firstName, lastName); });
        }
    }
}
