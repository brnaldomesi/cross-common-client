using System;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public class SelectPageParametersModel
    {
        public Guid Id { get; set; }

        private Guid _parent;
        public Guid Parent
        {
            get
            {
                if (Id.IsNotEmptyGuid())
                {
                    _parent = Id;
                }

                return _parent;
            }
            set { _parent = value; }
        }

        public Guid LastUid { get; set; }
        public int Take { get; set; }

        /// <summary>
        /// search term
        /// </summary>
        public string Q { get; set; }
    }
}