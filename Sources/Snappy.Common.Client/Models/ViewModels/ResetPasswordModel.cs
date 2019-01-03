using Snappy.Common.Client.Helpers;
using Snappy.Common.Client.Models.InputModels;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public sealed class ResetPasswordModel : BaseModel
    {
        public string Password { get; set; }
        public string ReEnterPassword { get; set; }

        public PasswordInputModel PasswordInput { get; }
        public PasswordInputModel ReEnterPasswordInput { get; }

        public ResetPasswordModel()
        {
            Title = Localizer.Localize("reset_password_title");

            PasswordInput = new PasswordInputModel("Password", "password", true);
            ReEnterPasswordInput = new PasswordInputModel("ReEnterNewPassword", "re_enter_password", true);
        }

        public override void SetInputModelValues()
        {
            PasswordInput.Value = Password;
            ReEnterPasswordInput.Value = ReEnterPassword;
        }

        public override void SetInputErrorMessages()
        {
            if (Password.IsEmpty())
            {
                PasswordInput.ErrorMessage.Add("password_required_error_message");
                InputErrorMessages.AddRange(PasswordInput.ErrorMessage);
            }

            if (ReEnterPassword.IsEmpty())
            {
                PasswordInput.ErrorMessage.Add("password_required_error_message");
                InputErrorMessages.AddRange(PasswordInput.ErrorMessage);
            }

            if (Password.IsNotValidPassword())
            {
                PasswordInput.ErrorMessage.Add("password_is_not_valid_error_message");
                InputErrorMessages.AddRange(PasswordInput.ErrorMessage);
            }

            if (ReEnterPassword.IsNotValidPassword())
            {
                ReEnterPasswordInput.ErrorMessage.Add("password_is_not_valid_error_message");
                InputErrorMessages.AddRange(ReEnterPasswordInput.ErrorMessage);
            }

            if (Password != ReEnterPassword)
            {
                ReEnterPasswordInput.ErrorMessage.Add("re_entered_password_does_not_match_error_message");
                InputErrorMessages.AddRange(ReEnterPasswordInput.ErrorMessage);
            }
        }
    }
}
