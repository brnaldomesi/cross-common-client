using Snappy.Common.Client.Helpers;
using Snappy.Common.Client.Models.InputModels;

namespace Snappy.Common.Client.Models.ViewModels
{
    public class OrganizationDetailUsersBaseModel : BaseModel
    {
        public string OrganizationUid { get; set; }
        public string UserUid { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool IsEmailValidated { get; set; }
        public bool IsActive { get; set; }

        public HiddenInputModel OrganizationUidInput { get; }
        public OrganizationDetailUsersBaseModel()
        {
            Title = Localizer.Localize("organization_users_title");

            OrganizationUidInput=new HiddenInputModel("OrganizationName","organization_uid");
        }
    }
}