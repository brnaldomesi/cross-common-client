using System;

using Snappy.Common.Helpers;
using Snappy.Common.Models.Requests;

namespace Snappy.Common.Client.Models.Requests.Membership
{
    public class PasswordResetRequest : BaseRequest
    {
        public string UserUid { get; }
        public string Password { get; }
        public string ReEnterPassword { get; }

        public PasswordResetRequest(string userUid, string password, string reEnterPassword)
        {
            if (userUid.IsNotUid())
            {
                throw new ArgumentException(nameof(userUid));
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
                throw new ArgumentException("password_and_re_entered_password_does_not_match", nameof(password));
            }

            UserUid = userUid;
            Password = password;
            ReEnterPassword = reEnterPassword;
        }
    }
}