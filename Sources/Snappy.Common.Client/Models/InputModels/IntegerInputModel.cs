namespace Snappy.Common.Client.Models.InputModels
{
    public class IntegerInputModel : InputModel
    {
        public new int Value { get; set; }

        public IntegerInputModel(string name, string labelKey, bool isRequired = false, int value = 0) : base(name, labelKey, isRequired, value.ToString())
        {
            Value = value;
        }
    }
}
