using Snappy.Common.Client.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public sealed class UserDetailModel : BaseModel
    {
        public string UserUId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string OrganizationId { get; set; }
        public string OrganizationName { get; set; }

        public int NumberOfFileDownloads { get; set; }
        public int NumberOfFileUploads { get; set; }
        public bool IsActive { get; set; }

        public UserDetailModel()
        {
            Title = Localizer.Localize("user_detail_title");
        }
    }
}
