using Snappy.Common.Client.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public class OrganizationDetailUsersBaseModel : BaseModel
    {
        public string UserUid { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool IsEmailValidated { get; set; }
        public bool IsActive { get; set; }

        public OrganizationDetailUsersBaseModel()
        {
            Title = Localizer.Localize("users_title");
        }
    }
}