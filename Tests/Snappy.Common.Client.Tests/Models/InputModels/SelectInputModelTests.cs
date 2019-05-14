using System;
using NUnit.Framework;

using Snappy.Common.Client.Models.InputModels;
using static Snappy.Common.Tests.Helpers.BaseTestDataHelper;
namespace Snappy.Common.Client.Tests.Models.InputModels
{
    [TestFixture]
    public class SelectInputModelTests
    {
        [TestCase(STRING, STRING_1, STRING_2, BOOL_TRUE, STRING_3, BOOL_TRUE, BOOL_TRUE, BOOL_TRUE, BOOL_FALSE, BOOL_TRUE, STRING_4)]
        [TestCase(STRING, STRING_1, STRING_2, BOOL_FALSE, STRING_3, BOOL_FALSE, BOOL_FALSE, BOOL_FALSE, BOOL_FALSE, BOOL_FALSE, STRING_4)]
        public void SelectInputModel(string name, string labelKey, string dataUrl, bool isRequired, string parent,
                                     bool isOptionTypeContent, bool isSetFirstItem, bool isAllOptionsVisible,
                                     bool isMultiple, bool isHavingDetailInfo, string detailInfoDataUrl)
        {
            var model = new SelectInputModel(name, labelKey, dataUrl, isRequired, parent,
                                             isOptionTypeContent, isSetFirstItem, isAllOptionsVisible,
                                             isMultiple, isHavingDetailInfo, detailInfoDataUrl);

            Assert.AreEqual(name, model.Name);
            Assert.AreEqual(labelKey, model.LabelKey);
            Assert.AreEqual(dataUrl, model.DataUrl);
            Assert.AreEqual(isRequired, model.IsRequired);
            Assert.AreEqual(parent, model.Parent);
            Assert.AreEqual(isOptionTypeContent, model.IsOptionTypeContent);
            Assert.AreEqual(isSetFirstItem, model.IsSetFirstItem);
            Assert.AreEqual(isAllOptionsVisible, model.IsAllOptionsVisible);
            Assert.AreEqual(isMultiple, model.IsMultiple);
            Assert.AreEqual(isHavingDetailInfo, model.IsHavingDetailInfo);
            Assert.AreEqual(detailInfoDataUrl, model.DetailInfoDataUrl);
        }

        [TestCase(STRING, STRING_1, STRING_2, BOOL_TRUE, STRING_3, BOOL_TRUE, BOOL_TRUE, BOOL_TRUE, BOOL_TRUE, BOOL_TRUE, STRING_4)]
        public void SelectInputModel_ThrowArgumentException(string name, string labelKey, string dataUrl, bool isRequired, string parent,
                                                            bool isOptionTypeContent, bool isSetFirstItem, bool isAllOptionsVisible,
                                                            bool isMultiple, bool isHavingDetailInfo, string detailInfoDataUrl)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new SelectInputModel(name, labelKey, dataUrl, isRequired,
                                     parent, isOptionTypeContent, isSetFirstItem,
                                     isAllOptionsVisible, isMultiple, isHavingDetailInfo,
                                     detailInfoDataUrl);
            });
        }
    }
}