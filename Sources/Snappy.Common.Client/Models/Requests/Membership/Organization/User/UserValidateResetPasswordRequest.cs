using System;

using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.User
{
    public class UserValidateResetPasswordRequest
    {
        public string Email { get; }
        public string Token { get; }

        public UserValidateResetPasswordRequest(string email, string token)
        {
            if (email.IsNotEmail())
            {
                throw new ArgumentException(nameof(email));
            }

            Email = email;
            Token = token;
        }
    }
}