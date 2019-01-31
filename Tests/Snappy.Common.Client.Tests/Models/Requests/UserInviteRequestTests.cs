using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests;
using Snappy.Common.Client.Models.Requests.Membership;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests
{
    [TestFixture]
    class UserInviteRequestTests
    {
        //[Test]
        //public void UserInviteRequest_Constructor()
        //{
        //    var request = new UserInviteRequest(TestDataHelper.CURRENT_USER_ID, TestDataHelper.EMAIL, TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME);
        //    Assert.AreEqual(TestDataHelper.CURRENT_USER_ID, request.CurrentUserId);
        //    Assert.AreEqual(TestDataHelper.EMAIL, request.Email);
        //    Assert.AreEqual(TestDataHelper.FIRSTNAME, request.FirstName);
        //    Assert.AreEqual(TestDataHelper.LASTNAME, request.LastName);
        //}

        //[TestCase(TestDataHelper.CURRENT_USER_ID, TestDataHelper.EMPTY_STRING, TestDataHelper.FIRSTNAME, TestDataHelper.LASTNAME)]
        //[TestCase(TestDataHelper.CURRENT_USER_ID, TestDataHelper.EMAIL, TestDataHelper.EMPTY_STRING, TestDataHelper.LASTNAME)]
        //[TestCase(TestDataHelper.CURRENT_USER_ID, TestDataHelper.EMAIL, TestDataHelper.FIRSTNAME, TestDataHelper.EMPTY_STRING)]
        public void UserInviteRequest_Argument_Validations(int currentUserId, string email, string firstName, string lastName)
        {
            Assert.Throws<ArgumentException>(() => { new UserInviteRequest(currentUserId, email, firstName, lastName); });
        }
    }
}
