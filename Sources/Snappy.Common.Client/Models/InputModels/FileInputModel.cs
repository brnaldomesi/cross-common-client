namespace Snappy.Common.Client.Models.InputModels
{
    public class FileInputModel : InputModel
    {
        public bool IsMultiple { get; set; }

        public FileInputModel(string name, string labelKey, bool isRequired = false, bool isMultiple = false, string value = "") : base(name, labelKey, isRequired, value)
        {
            IsMultiple = isMultiple;
        }
    }
}