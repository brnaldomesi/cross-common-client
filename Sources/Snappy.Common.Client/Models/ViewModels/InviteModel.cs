using Snappy.Common.Client.Helpers;
using Snappy.Common.Client.Models.InputModels;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public sealed class InviteModel : BaseModel
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public EmailInputModel EmailInput { get; }
        public InputModel FirstNameInput { get; }
        public InputModel LastNameInput { get; }

        public InviteModel()
        {
            Title = Localizer.Localize("user_invite_title");

            EmailInput = new EmailInputModel("Email", "email", true);
            FirstNameInput = new InputModel("FirstName", "first_name", true);
            LastNameInput = new InputModel("LastName", "last_name", true);
        }

        public override void SetInputModelValues()
        {
            EmailInput.Value = Email;
            FirstNameInput.Value = FirstName;
            LastNameInput.Value = LastName;
        }

        public override void SetInputErrorMessages()
        {
            if (Email.IsEmpty())
            {
                EmailInput.ErrorMessage.Add("email_required_error_massage");
                InputErrorMessages.AddRange(EmailInput.ErrorMessage);
            }

            if (Email.IsNotEmail())
            {
                EmailInput.ErrorMessage.Add("email_is_not_valid_error_message");
                InputErrorMessages.AddRange(EmailInput.ErrorMessage);
            }

            if (FirstName.IsEmpty())
            {
                FirstNameInput.ErrorMessage.Add("first_name_required_error_massage");
                InputErrorMessages.AddRange(FirstNameInput.ErrorMessage);
            }

            if (LastName.IsEmpty())
            {
                LastNameInput.ErrorMessage.Add("last_name_required_error_massage");
                InputErrorMessages.AddRange(LastNameInput.ErrorMessage);
            }
        }
    }
}