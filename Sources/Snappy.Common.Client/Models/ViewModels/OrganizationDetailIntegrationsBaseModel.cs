using Snappy.Common.Client.Helpers;
using Snappy.Common.Client.Models.InputModels;

namespace Snappy.Common.Client.Models.ViewModels
{
    public class OrganizationDetailIntegrationsBaseModel : BaseModel
    {
        public string OrganizationUid { get; set; }
        public string IntegrationUid { get; set; }
        public string IntegrationName { get; set; }
        public string Description { get; set; }
        public string IsActive { get; set; }

        public HiddenInputModel OrganizationUidInput { get; }

        public OrganizationDetailIntegrationsBaseModel()
        {
            Title = Localizer.Localize("organization_integrations_title");

            OrganizationUidInput = new HiddenInputModel("OrganizationUid", "organization_uid");
        }
    }
}