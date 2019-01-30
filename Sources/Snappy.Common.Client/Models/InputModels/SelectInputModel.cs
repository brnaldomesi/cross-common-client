namespace Snappy.Common.Client.Models.InputModels
{
    public class SelectInputModel : InputModel
    {
        public string DataUrl { get; set; }
        public string Parent { get; set; }

        public SelectInputModel(string name, string labelKey, string dataUrl,
                                string parent = "", bool isRequired = false)
                                : base(name, labelKey, isRequired)
        {
            DataUrl = dataUrl;
            Parent = parent;
        }
    }
}