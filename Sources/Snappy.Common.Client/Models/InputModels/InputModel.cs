using System.Collections.Generic;

namespace Snappy.Common.Client.Models.InputModels
{
    public class InputModel
    {
        public string Name { get; }
        public string LabelKey { get; }
        public string InfoText { get; set; }
        public bool IsRequired { get; }
        public bool IsVisibilityConditional { get; set; }
        public string Value { get; set; }
        public List<string> ErrorMessage { get; set; }

        public InputModel(string name, string labelKey, bool isRequired, string value) : this(name, labelKey, isRequired)
        {
            Value = value;
        }

        public InputModel(string name, string labelKey, bool isRequired) : this(name, labelKey)
        {
            IsRequired = isRequired;
        }

        public InputModel(string name, string labelKey)
        {
            Name = name;
            LabelKey = labelKey;
            ErrorMessage = new List<string>();
        }
    }
}