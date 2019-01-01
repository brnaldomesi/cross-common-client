using Snappy.Common.Client.Helpers;
using Snappy.Common.Client.Models.InputModels;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    class DemandPasswordResetModel : BaseModel
    {
        public string Email { get; set; }

        public EmailInputModel EmailInput { get; }

        public DemandPasswordResetModel()
        {
            Title = Localizer.Localize("demand_password_reset_title");

            EmailInput = new EmailInputModel("Email", "email", true);
        }

        public override void SetInputModelValues()
        {
            EmailInput.Value = Email;
        }

        public override void SetInputErrorMessages()
        {
            if (Email.IsEmpty())
            {
                EmailInput.ErrorMessage.Add("email_required_error_message");
                InputErrorMessages.AddRange(EmailInput.ErrorMessage);
            }

            if (Email.IsNotEmail())
            {
                EmailInput.ErrorMessage.Add("email_is_not_valid_error_message");
                InputErrorMessages.AddRange(EmailInput.ErrorMessage);
            }
        }
    }
}
