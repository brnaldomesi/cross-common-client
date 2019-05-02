using System;

namespace Snappy.Common.Client.Models.ViewModels
{
    public class SelectPageParametersModel
    {
        public Guid Parent { get; set; }

        public Guid LastUid { get; set; }
        public int Take { get; set; }

        /// <summary>
        /// search term
        /// </summary>
        public string Q { get; set; }
    }
}