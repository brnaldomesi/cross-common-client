using Snappy.Common.Client.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public sealed class UserDetail : BaseModel
    {
        public string UserUId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string OrganizationUId { get; set; }
        public string OrganizationName { get; set; }
        public int TranslatedLabelCount { get; set; }
        public int AddedLabelCount { get; set; }
        public bool IsActive { get; set; }

        public UserDetail()
        {
            Title = Localizer.Localize("user_detail_title");
        }
    }
}