namespace Snappy.Common.Client.Models.InputModels
{
    public class TextareaInputModel : InputModel
    {
        public TextareaInputModel(string name, string labelKey, bool isRequired = false, string value = "") : base(name, labelKey, isRequired, value)
        {
        }
    }
}