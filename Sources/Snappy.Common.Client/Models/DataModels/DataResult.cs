using System;
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
            for (var i = 0; i < name.Length; i++)
            {
                var item = name[i];
                Headers.Add(new DataHeaderInfo { Key = item, DisplayIndex = i });
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

        public string PrepareButton(string name, string onClick, string className, string confirmTitle, string confirmContent)
        {
            return $"<button type='button' data-confirm-title='{confirmTitle}' data-confirm-content='{confirmContent}' class='btn {className}' onclick='{onClick}' data-translation='{name}'>{name}</button>";
        }

        public string PrepareDeleteButton(string name, string postUrl, string confirmTitle = "are_you_sure_you_want_to_delete_title", string confirmContent = "are_you_sure_you_want_to_delete_content")
        {
            return PrepareButton(name, $"handleDeleteRow(this, \"{postUrl}\")", "btn-delete", confirmTitle, confirmContent);
        }

        public string PrepareChangeActivationButton(string name, string postUrl, string confirmTitle = "are_you_sure_you_want_to_change_activation_title", string confirmContent = "are_you_sure_you_want_to_change_activation_content")
        {
            return PrepareButton(name, $"handleChangeActivationRow(this, \"{postUrl}\")", "btn-secondary", confirmTitle, confirmContent);
        }
    }

    public class DataHeaderInfo
    {
        public int DisplayIndex { get; set; }
        public string Key { get; set; }
        public int WidthPercent { get; set; }
        public string AlignmentHorizontal { get; set; }
        public string AlignmentVertical { get; set; }
    }
}