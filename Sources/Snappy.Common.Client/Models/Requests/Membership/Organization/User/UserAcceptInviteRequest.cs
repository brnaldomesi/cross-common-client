using System;

using Snappy.Common.Helpers;
using Snappy.Common.Models.Requests;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.User
{
    public sealed class UserAcceptInviteRequest : BaseRequest
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Password { get; }
        public string ReEnterPassword { get; }

        public UserAcceptInviteRequest(string firstName, string lastName, string password, string reEnterPassword)
        {
            if (firstName.IsEmpty())
            {
                throw new ArgumentException(nameof(firstName));
            }

            if (lastName.IsEmpty())
            {
                throw new ArgumentException(nameof(lastName));
            }

            if (password.IsNotValidPassword())
            {
                throw new ArgumentException(nameof(password));
            }

            if (reEnterPassword.IsNotValidPassword())
            {
                throw new ArgumentException(nameof(reEnterPassword));
            }

            if (password != reEnterPassword)
            {
                throw new ArgumentException("new_password_and_re_entered_password_does_not_match", nameof(password));
            }

            FirstName = firstName;
            LastName = lastName;
            Password = password;
            ReEnterPassword = reEnterPassword;
        }
    }
}
