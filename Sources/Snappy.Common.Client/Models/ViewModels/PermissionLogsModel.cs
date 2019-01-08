using System;

using Snappy.Common.Client.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public class PermissionLogsModel : BaseModel
    {
        public string UserUId { get; set; }
        public string UserName { get; set; }
        public string AccessToken { get; set; }
        public string Permission { get; set; }
        public bool IsAllowed { get; set; }
        public DateTime CreatedAt { get; set; }

        public PermissionLogsModel()
        {
            Title = Localizer.Localize("permission_logs_tittle");
        }
    }
}