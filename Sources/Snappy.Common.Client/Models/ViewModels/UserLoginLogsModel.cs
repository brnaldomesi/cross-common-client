using System;

using Snappy.Common.Client.Helpers;
using Snappy.Common.Client.Models.InputModels;

namespace Snappy.Common.Client.Models.ViewModels
{
    public sealed class UserLoginLogsModel : BaseModel
    {
        public string OrganizationUid { get; set; }
        public string UserUid { get; set; }
        public string UserName { get; set; }
        public string Ip { get; set; }
        public string IpLocation { get; set; }
        public string Browser { get; set; }
        public string Platform { get; set; }
        public DateTime CreatedAt { get; set; }

        public HiddenInputModel OrganizationUidInput { get; }

        public UserLoginLogsModel()
        {
            Title = Localizer.Localize("user_login_logs_title");

            OrganizationUidInput = new HiddenInputModel("OrganizationName", "organization_uid");
        }
    }
}