using Snappy.Common.Client.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public class OrganizationDetailIntegrationsBaseModel : BaseModel
    {
        public string IntegrationUid { get; set; }
        public string IntegrationName { get; set; }
        public string Description { get; set; }
        public string IsActive { get; set; }

        public OrganizationDetailIntegrationsBaseModel()
        {
            Title = Localizer.Localize("integrations_title");
        }
    }
}