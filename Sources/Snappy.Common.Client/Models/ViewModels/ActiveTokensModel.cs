using Snappy.Common.Client.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public class ActiveTokensModel : BaseModel
    {
        public string IntegrationUid { get; set; }
        public string IntegrationName { get; set; }
        public string ClientUid { get; set; }

        public ActiveTokensModel()
        {
            Title = Localizer.Localize("active_tokens_title");
        }
    }
}