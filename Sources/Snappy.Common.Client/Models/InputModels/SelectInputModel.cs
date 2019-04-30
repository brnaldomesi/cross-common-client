namespace Snappy.Common.Client.Models.InputModels
{
    public class SelectInputModel : InputModel
    {
        public bool IsOptionTypeContent { get; set; }
        public bool IsAllOptionsVisible { get; set; }
        public bool IsMultiple { get; set; }
        public bool IsHavingDetailInfo { get; set; }

        public string DetailInfoDataUrl { get; set; }
        public string DataUrl { get; set; }
        public string Parent { get; set; }

        public SelectInputModel(string name, string labelKey, string dataUrl,
                                bool isRequired = false, string parentId = "", bool isOptionTypeContent = false,
                                bool isAllOptionsVisible = false, bool isMultiple = false, bool isHavingDetailInfo = false,
                                string detailInfoDataUrl = "") : base(name, labelKey, isRequired)
        {
            DataUrl = dataUrl;
            Parent = parentId;
            DetailInfoDataUrl = detailInfoDataUrl;
            IsOptionTypeContent = isOptionTypeContent;
            IsAllOptionsVisible = isAllOptionsVisible;
            IsMultiple = isMultiple;
            IsHavingDetailInfo = isHavingDetailInfo;
        }
    }
}