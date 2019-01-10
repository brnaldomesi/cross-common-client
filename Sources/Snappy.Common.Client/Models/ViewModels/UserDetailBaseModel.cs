using Snappy.Common.Client.Helpers;
using Snappy.Common.Client.Models.InputModels;

namespace Snappy.Common.Client.Models.ViewModels
{
    public class UserDetailBaseModel : BaseModel
    {
        public string UserUid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string OrganizationUid { get; set; }
        public string OrganizationName { get; set; }

        public string InvitedByUserUid { get; set; }
        public string InvitedByUserName { get; set; }

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set
            {
                _isActive = value;
                IsActiveInput.Value = _isActive;
            }
        }

        public CheckboxInputModel IsActiveInput { get; set; }

        public UserDetailBaseModel()
        {
            Title = Localizer.Localize("user_detail_title");

            IsActiveInput = new CheckboxInputModel("IsActive", "is_active", false, true);
        }
    }
}