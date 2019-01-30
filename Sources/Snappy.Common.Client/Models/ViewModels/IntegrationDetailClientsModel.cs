using Snappy.Common.Client.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public class IntegrationDetailClientsModel : BaseModel
    {
        public string ClientUid { get; set; }
        public string ClientSecret { get; set; }
        public string IsActive { get; set; }

        public IntegrationDetailClientsModel()
        {
            Title = Localizer.Localize("integration_clients_title");
        }
    }
}