using Snappy.Common.Client.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public class IntegrationDetailClientsDataModel : BaseModel
    {
        public string ClientUid { get; set; }
        public string ClientSecret { get; set; }
        public string IsActive { get; set; }

        public IntegrationDetailClientsDataModel()
        {
            Title = Localizer.Localize("integration_clients_title");
        }
    }
}