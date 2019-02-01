using System;

using Snappy.Common.Client.Helpers;
using Snappy.Common.Client.Models.InputModels;

namespace Snappy.Common.Client.Models.ViewModels
{
    public sealed class TokenRequestLogsModel : BaseModel
    {
        public string OrganizationUid { get; set; }
        public string IntegrationUid { get; set; }
        public string IntegrationName { get; set; }
        public string AccessToken { get; set; }
        public string Ip { get; set; }
        public string IpLocation { get; set; }
        public string HttpMethod { get; set; }
        public string ResponseCode { get; set; }
        public DateTime CreatedAt { get; set; }

        public HiddenInputModel OrganizationUidInput { get; }

        public TokenRequestLogsModel()
        {
            Title = Localizer.Localize("token_request_logs_title");

            OrganizationUidInput = new HiddenInputModel("OrganizationUid", "organization_uid");
        }
    }
}