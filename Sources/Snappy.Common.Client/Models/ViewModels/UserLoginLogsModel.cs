using System;

using Snappy.Common.Client.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public class UserLoginLogsModel : BaseModel
    {
        public string UserUId { get; set; }
        public string UserName { get; set; }
        public string Ip { get; set; }
        public string IpLocation { get; set; }
        public string Browser { get; set; }
        public string Platform { get; set; }
        public DateTime CreatedAt { get; set; }

        public UserLoginLogsModel()
        {
            Title = Localizer.Localize("user_login_logs_tittle");
        }
    }
}