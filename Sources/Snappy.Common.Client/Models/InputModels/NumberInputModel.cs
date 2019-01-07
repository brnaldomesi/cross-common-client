namespace Snappy.Common.Client.Models.InputModels
{
    public class NumberInputModel : InputModel
    {
        public new int Value { get; set; }

        public NumberInputModel(string name, string labelKey, bool isRequired = false, int value = 0) : base(name, labelKey, isRequired, value.ToString())
        {
            Value = value;
        }
    }
}
