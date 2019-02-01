namespace Snappy.Common.Client.Models.InputModels
{
    public class HiddenInputModel : InputModel
    {
        public HiddenInputModel(string name, string value = "") : base(name, "", false, value)
        {
        }
    }
}