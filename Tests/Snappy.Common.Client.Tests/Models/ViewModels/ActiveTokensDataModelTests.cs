﻿using NUnit.Framework;

using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Client.Tests.Models.ViewModels.Base;

namespace Snappy.Common.Client.Tests.Models.ViewModels
{
    [TestFixture]
    public class ActiveTokensDataModelTests : BaseViewModelTest<ActiveTokensDataModel>
    {
        public ActiveTokensDataModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetModel();
        }

        [Test]
        public void ActiveTokensDataModel_title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "active_tokens_table_title");
        }
    }
}