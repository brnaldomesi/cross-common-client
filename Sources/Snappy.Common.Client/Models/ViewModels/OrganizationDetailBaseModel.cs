using Snappy.Common.Client.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public class OrganizationDetailBaseModel : BaseModel
    {
        public string OrganizationUid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public OrganizationDetailBaseModel()
        {
            Title = Localizer.Localize("organization_detail_title");
        }
    }
}