namespace Snappy.Common.Client.Models.InputModels
{
    public class UrlInputModel : InputModel
    {
        public UrlInputModel(string name, string labelKey, bool isRequired = false, string value = "") : base(name, labelKey, isRequired, value)
        {
        }
    }
}