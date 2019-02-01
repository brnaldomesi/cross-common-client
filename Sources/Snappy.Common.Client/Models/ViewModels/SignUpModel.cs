using Snappy.Common.Client.Helpers;
using Snappy.Common.Client.Models.InputModels;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public sealed class SignUpModel : BaseModel
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OrganizationName { get; set; }
        public string Password { get; set; }
        public bool IsTermsAccepted { get; set; }

        public EmailInputModel EmailInput { get; }
        public InputModel FirstNameInput { get; }
        public InputModel LastNameInput { get; }
        public LongInputModel OrganizationNameInput { get; }
        public PasswordInputModel PasswordInput { get; }
        public CheckboxInputModel IsTermsAcceptedInput { get; }

        public SignUpModel()
        {
            Title = Localizer.Localize("sign_up_title");

            EmailInput = new EmailInputModel("Email", "email", true);
            FirstNameInput = new InputModel("FirstName", "first_name", true);
            LastNameInput = new InputModel("LastName", "last_name", true);
            OrganizationNameInput = new LongInputModel("OrganizationName", "organization_name", true);
            PasswordInput = new PasswordInputModel("Password", "password", true);
            IsTermsAcceptedInput = new CheckboxInputModel("IsTermsAccepted", "is_term_accepted", true);
        }

        public override void SetInputModelValues()
        {
            EmailInput.Value = Email;
            FirstNameInput.Value = FirstName;
            LastNameInput.Value = LastName;
            OrganizationNameInput.Value = OrganizationName;
            PasswordInput.Value = Password;
            IsTermsAcceptedInput.Value = IsTermsAccepted;
        }

        public override void SetInputErrorMessages()
        {
            if (Email.IsEmpty())
            {
                EmailInput.ErrorMessage.Add("email_required_error_message");
                InputErrorMessages.AddRange(EmailInput.ErrorMessage);
            }

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

            if (OrganizationName.IsEmpty())
            {
                OrganizationNameInput.ErrorMessage.Add("organization_name_required_error_message");
                InputErrorMessages.AddRange(OrganizationNameInput.ErrorMessage);
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

            if (!IsTermsAccepted)
            {
                IsTermsAcceptedInput.ErrorMessage.Add("you_must_accept_terms_error_message");
                InputErrorMessages.AddRange(IsTermsAcceptedInput.ErrorMessage);
            }
        }
    }
}