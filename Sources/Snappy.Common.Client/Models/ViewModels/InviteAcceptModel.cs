using Snappy.Common.Client.Helpers;
using Snappy.Common.Client.Models.InputModels;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public sealed class InviteAcceptModel : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NewPassword { get; set; }
        public string ReEnterNewPassword { get; set; }

        public InputModel FirstNameInput { get; }
        public InputModel LastNameInput { get; }
        public PasswordInputModel NewPasswordInput { get; }
        public PasswordInputModel ReEnterNewPasswordInput { get; }

        public InviteAcceptModel()
        {
            Title = Localizer.Localize("accept_invite_title");

            FirstNameInput = new InputModel("FirstName", "first_name", true);
            LastNameInput = new InputModel("LastName", "last_name", true);
            NewPasswordInput = new PasswordInputModel("NewPassword", "new_password", true);
            ReEnterNewPasswordInput = new PasswordInputModel("ReEnterNewPassword", "re_enter_new_password", true);
        }

        public override void SetInputModelValues()
        {
            FirstNameInput.Value = FirstName;
            LastNameInput.Value = LastName;
            NewPasswordInput.Value = NewPassword;
            ReEnterNewPasswordInput.Value = ReEnterNewPassword;
        }

        public override void SetInputErrorMessages()
        {
            if (FirstName.IsEmpty())
            {
                FirstNameInput.ErrorMessage.Add("first_name_required_error_message");
                InputErrorMessages.AddRange(FirstNameInput.ErrorMessage);
            }

            if (LastName.IsEmpty())
            {
                LastNameInput.ErrorMessage.Add("last_name_required_error_message");
                InputErrorMessages.AddRange(LastNameInput.ErrorMessage);
            }

            if (NewPassword.IsEmpty())
            {
                NewPasswordInput.ErrorMessage.Add("password_required_error_message");
                InputErrorMessages.AddRange(NewPasswordInput.ErrorMessage);
            }

            if (ReEnterNewPassword.IsEmpty())
            {
                ReEnterNewPasswordInput.ErrorMessage.Add("password_required_error_message");
                InputErrorMessages.AddRange(ReEnterNewPasswordInput.ErrorMessage);
            }

            if (NewPassword.IsNotValidPassword())
            {
                NewPasswordInput.ErrorMessage.Add("password_is_not_valid_error_message");
                InputErrorMessages.AddRange(NewPasswordInput.ErrorMessage);
            }

            if (ReEnterNewPassword.IsNotValidPassword())
            {
                ReEnterNewPasswordInput.ErrorMessage.Add("password_is_not_valid_error_message");
                InputErrorMessages.AddRange(ReEnterNewPasswordInput.ErrorMessage);
            }

            if (NewPassword != ReEnterNewPassword)
            {
                ReEnterNewPasswordInput.ErrorMessage.Add("re_entered_password_does_not_match_error_message");
                InputErrorMessages.AddRange(ReEnterNewPasswordInput.ErrorMessage);
            }
        }
    }
}
