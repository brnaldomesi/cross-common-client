using Snappy.Common.Client.Helpers;
using Snappy.Common.Client.Models.InputModels;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public sealed class LogOnModel : BaseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public EmailInputModel EmailInput { get; }
        public PasswordInputModel PasswordInput { get; }

        public LogOnModel()
        {
            Title = Localizer.Localize("log_on_title");

            EmailInput = new EmailInputModel("Email", "email", true);
            PasswordInput = new PasswordInputModel("Password", "password", true);
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

            if (Password.IsEmpty())
            {
                PasswordInput.ErrorMessage.Add("password_required_error_message");
                InputErrorMessages.AddRange(PasswordInput.ErrorMessage);
            }

            if (Email.IsNotEmail())
            {
                EmailInput.ErrorMessage.Add("email_is_not_valid_error_message");
                InputErrorMessages.AddRange(EmailInput.ErrorMessage);
            }

            if (Password.IsNotValidPassword())
            {
                PasswordInput.ErrorMessage.Add("password_is_not_valid_error_message");
                InputErrorMessages.AddRange(PasswordInput.ErrorMessage);
            }
        }
    }
}