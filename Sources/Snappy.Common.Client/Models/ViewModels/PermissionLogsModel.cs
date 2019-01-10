using System;

using Snappy.Common.Client.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public sealed class PermissionLogsModel : BaseModel
    {
        public string UserUid { get; set; }
        public string UserName { get; set; }

        public string IntegrationUid { get; set; }
        public string IntegrationName { get; set; }
        public string AccessToken { get; set; }

        public string Permission { get; set; }
        public bool IsAllowed { get; set; }
        public DateTime CreatedAt { get; set; }

        public PermissionLogsModel()
        {
            Title = Localizer.Localize("permission_logs_title");
        }
    }
}