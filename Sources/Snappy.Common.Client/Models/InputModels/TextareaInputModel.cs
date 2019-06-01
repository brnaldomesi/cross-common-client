namespace Snappy.Common.Client.Models.InputModels
{
    public class TextareaInputModel : InputModel
    {
        public int Rows { get; set; }
        public int Cols { get; set; }

        public TextareaInputModel(string name, string labelKey, bool isRequired = false, string value = "") : base(name, labelKey, isRequired, value)
        {
            Rows = 5;
            Cols = 70;
        }
    }
}