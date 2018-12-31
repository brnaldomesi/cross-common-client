using System.Collections.Generic;

namespace Snappy.Common.Client.Models.InputModels
{
    public class InputModel
    {
        public string Name { get; }
        public string LabelKey { get; }
        public bool IsRequired { get; }
        public string Value { get; set; }
        public List<string> ErrorMessage { get; set; }

        public InputModel(string name, string labelKey, bool isRequired = false, string value = "")
        {
            Name = name;
            LabelKey = labelKey;
            IsRequired = isRequired;
            Value = value;
            ErrorMessage = new List<string>();
        }
    }
}