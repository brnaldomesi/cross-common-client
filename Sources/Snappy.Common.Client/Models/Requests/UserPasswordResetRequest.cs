using System;

using Snappy.Common.Helpers;
using Snappy.Common.Models.Requests;

namespace Snappy.Common.Client.Models.Requests
{
    public sealed class UserPasswordResetRequest : BaseRequest
    {
        public string Email { get; }
        public string Token { get; }
        public string Password { get; }

        public UserPasswordResetRequest(string email, string token, string password)
        {
            if (email.IsNotEmail())
            {
                throw new ArgumentException(nameof(email));
            }

            if (token.IsNotUid())
            {
                throw new ArgumentException(nameof(token));
            }

            if (password.IsNotValidPassword())
            {
                throw new ArgumentException(nameof(password));
            }

            Email = email;
            Token = token;
            Password = password;
        }
    }
}
