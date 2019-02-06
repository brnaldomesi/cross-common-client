using System;

using NUnit.Framework;

using Snappy.Common.Client.Models.Requests.Membership;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Tests.Models.Requests.Membership
{
    [TestFixture]
    public class IntegrationTokenBaseRequestTests
    {
        //[Test]
        //public void IntegrationTokenBaseRequest_Constructor()
        //{
        //    var request = new IntegrationTokenBaseRequest(TestDataHelper.Uid, TestDataHelper.Uid_1);

        //    Assert.AreEqual(TestDataHelper.Uid, request.IntegrationUid);
        //    Assert.AreEqual(TestDataHelper.Uid_1, request.TokenUid);
        //}

        //[TestCase(TestDataHelper.EMPTY_STRING, TestDataHelper.Uid_1)]
        //[TestCase(TestDataHelper.Uid, TestDataHelper.EMPTY_STRING)]
        //[TestCase(TestDataHelper.STRING, TestDataHelper.STRING)]
        //public void IntegrationTokenBaseRequest_Argument_Validations(string integrationUid, string tokenUid)
        //{
        //    Assert.Throws<ArgumentException>(() =>
        //    {
        //        new IntegrationTokenBaseRequest(integrationUid, tokenUid);
        //    });
        //}
    }
}