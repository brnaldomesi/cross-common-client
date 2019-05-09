using System.Collections.Generic;

namespace Snappy.Common.Client.Models.DataModels
{
    public class CommonResult
    {
        public bool IsOk { get; set; }
        public List<string> Messages { get; set; }

        public CommonResult()
        {
            Messages = new List<string>();
        }
    }
}