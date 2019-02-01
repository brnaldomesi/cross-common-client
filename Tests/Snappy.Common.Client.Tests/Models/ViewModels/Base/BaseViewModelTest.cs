using System.Collections.Generic;

using NUnit.Framework;

using Snappy.Common.Client.Models.InputModels;

namespace Snappy.Common.Client.Tests.Models.ViewModels.Base
{
    public class BaseViewModelTest<T> where T : class, new()
    {
        public static T GetModel()
        {
            return new T();
        }

        public static void AssertModelValidation(bool isValid)
        {
            Assert.True(!isValid);
            Assert.False(isValid);
        }

        public static void AssertInputErrorMessages(List<string> inputErrorMessages, string[] errorMessages)
        {
            foreach (var message in errorMessages)
            {
                Assert.True(inputErrorMessages.Contains(message));
            }
        }

        public static void AssertInputModel(InputModel model, string name, string labelKey, bool isRequired)
        {
            Assert.AreEqual(model.Name, name);
            Assert.AreEqual(model.LabelKey, labelKey);
            Assert.AreEqual(model.IsRequired, isRequired);
            Assert.IsEmpty(model.Value);
        }

        public static void AssertCheckBoxInputModel(CheckboxInputModel model, string name, string labelKey, bool isRequired)
        {
            Assert.AreEqual(model.Name, name);
            Assert.AreEqual(model.LabelKey, labelKey);
            Assert.AreEqual(model.IsRequired, isRequired);
            Assert.False(model.Value);
        }
    }
}
