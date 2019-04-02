using System.Collections.Generic;
using Snappy.Common.Models.Shared;

namespace Snappy.Common.Client.Models.DataModels
{
    public class DataResult
    {
        public const string SEPARATOR = ",_,";

        public List<DataHeaderInfo> Headers { get; set; }
        public List<string> Data { get; set; }
        public PagingInfo PagingInfo { get; set; }

        public DataResult()
        {
            Headers = new List<DataHeaderInfo>();
            Data = new List<string>();
            PagingInfo = new PagingInfo();
        }

        public void AddHeaders(params string[] name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                var item = name[i];
                Headers.Add(new DataHeaderInfo { Key = item, DisplayOrder = i });
            }
        }

        public string PrepareImage(string srcAttribute, string altAttribute = "")
        {
            return $"<img src='{srcAttribute}' alt='{altAttribute}' title='{altAttribute}' />";
        }

        public string PrepareLink(string url, string name, bool isTargetBlank = false)
        {
            var targetBlank = string.Empty;
            if (isTargetBlank)
            {
                targetBlank = " target='_blank'";
            }

            return $"<a href='{url}'{targetBlank}>{name}</a>";
        }

        public string PrepareLink(string url, bool isTargetBlank = true)
        {
            return PrepareLink(url, url, isTargetBlank);
        }
    }

    public class DataHeaderInfo
    {
        public int DisplayOrder { get; set; }
        public string Key { get; set; }
        public int WidthPercent { get; set; }
        public string AlignmentHorizontal { get; set; }
        public string AlignmentVertical { get; set; }
    }
}