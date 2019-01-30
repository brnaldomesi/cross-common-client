using Snappy.Common.Client.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public class ActiveTokensDataModel : BaseModel
    {
        public string TokenUid { get; set; }
        public string Ip { get; set; }
        public string CreatedAt { get; set; }
        public string ExpiresAt { get; set; }

        public ActiveTokensDataModel()
        {
            Title = Localizer.Localize("active_tokens_table_title");
        }
    }
}