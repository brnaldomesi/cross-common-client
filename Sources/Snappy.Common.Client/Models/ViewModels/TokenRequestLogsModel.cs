using System;

using Snappy.Common.Client.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public sealed class TokenRequestLogsModel : BaseModel
    {
        public string UserUId { get; set; }
        public string IntegrationUId { get; set; }
        public string IntegrationName { get; set; }
        public string AccessToken { get; set; }
        public string Ip { get; set; }
        public string IpLocation { get; set; }
        public string HttpMethod { get; set; }
        public string ResponseCode { get; set; }
        public DateTime CreatedAt { get; set; }

        public TokenRequestLogsModel()
        {
            Title = Localizer.Localize("token_request_logs_tittle");
        }
    }
}