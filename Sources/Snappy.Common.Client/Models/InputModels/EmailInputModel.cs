namespace Snappy.Common.Client.Models.InputModels
{
    public class EmailInputModel : InputModel
    {
        public EmailInputModel(string name, string labelKey, bool isRequired = false) : base(name, labelKey, isRequired)
        {
        }
    }
}