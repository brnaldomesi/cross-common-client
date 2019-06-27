using System.Collections.Generic;

namespace Snappy.Common.Client.Models.InputModels
{
    public class RadioInputModel : InputModel
    {
        public List<string> Items { get; set; }

        public RadioInputModel(string name, string legendKey, bool isRequired) : base(name, legendKey, isRequired)
        {
            Items = new List<string>();
        }
    }
}