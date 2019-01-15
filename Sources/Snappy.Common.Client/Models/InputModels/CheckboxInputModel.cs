namespace Snappy.Common.Client.Models.InputModels
{
    public class CheckboxInputModel : InputModel
    {
        public bool IsReadOnly { get; set; }
        public new bool Value { get; set; }

        public CheckboxInputModel(string name, string labelKey, bool isRequired = false, 
                                  bool isReadOnly = false, bool value = false) 
                                : base(name, labelKey, isRequired, value.ToString())
        {
            Value = value;
            IsReadOnly = isReadOnly;
        }
    }
}