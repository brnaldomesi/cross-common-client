using Snappy.Common.Client.Helpers;
using Snappy.Common.Client.Models.InputModels;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public sealed class ChangePasswordModel : BaseModel
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ReEnterNewPassword { get; set; }

        public PasswordInputModel OldPasswordInput { get; }
        public PasswordInputModel NewPasswordInput { get; }
        public PasswordInputModel ReEnterNewPasswordInput { get; }

        public ChangePasswordModel()
        {
            Title = Localizer.Localize("user_change_password_title");

            OldPasswordInput = new PasswordInputModel("OldPassword", "old_password", true);
            NewPasswordInput = new PasswordInputModel("NewPassword", "new_password", true);
            ReEnterNewPasswordInput = new PasswordInputModel("ReEnterNewPassword", "re_enter_new_password", true);
        }

        public override void SetInputModelValues()
        {
            OldPasswordInput.Value = OldPassword;
            NewPasswordInput.Value = NewPassword;
            ReEnterNewPasswordInput.Value = ReEnterNewPassword;
        }

        public override void SetInputErrorMessages()
        {
            if (OldPassword.IsEmpty())
            {
                OldPasswordInput.ErrorMessage.Add("old_password_required_error_message");
                InputErrorMessages.AddRange(OldPasswordInput.ErrorMessage);
            }

            if (NewPassword.IsEmpty())
            {
                NewPasswordInput.ErrorMessage.Add("new_password_required_error_message");
                InputErrorMessages.AddRange(NewPasswordInput.ErrorMessage);
            }

            if (ReEnterNewPassword.IsEmpty())
            {
                ReEnterNewPasswordInput.ErrorMessage.Add("re_entered_password_required_error_message");
                InputErrorMessages.AddRange(ReEnterNewPasswordInput.ErrorMessage);
            }

            if (OldPassword.IsNotValidPassword())
            {
                OldPasswordInput.ErrorMessage.Add("old_password_is_not_valid_error_message");
                InputErrorMessages.AddRange(OldPasswordInput.ErrorMessage);
            }

            if (NewPassword.IsNotValidPassword())
            {
                NewPasswordInput.ErrorMessage.Add("new_password_is_not_valid_error_message");
                InputErrorMessages.AddRange(NewPasswordInput.ErrorMessage);
            }

            if (ReEnterNewPassword.IsNotValidPassword())
            {
                ReEnterNewPasswordInput.ErrorMessage.Add("re_entered_password_is_not_valid_error_message");
                InputErrorMessages.AddRange(ReEnterNewPasswordInput.ErrorMessage);
            }

            if (OldPassword == NewPassword)
            {
                NewPasswordInput.ErrorMessage.Add("new_password_can_not_same_as_old_password_error_message");
                InputErrorMessages.AddRange(NewPasswordInput.ErrorMessage);
            }

            if (NewPassword != ReEnterNewPassword)
            {
                ReEnterNewPasswordInput.ErrorMessage.Add("re_entered_password_does_not_match_error_message");
                InputErrorMessages.AddRange(ReEnterNewPasswordInput.ErrorMessage);
            }
        }
    }
}