using System;

using Snappy.Common.Helpers;
using Snappy.Common.Models.Requests;

namespace Snappy.Common.Client.Models.Requests.Membership
{
    public sealed class LogOnRequest : BaseRequest
    {
        public string Email { get; }
        public string Password { get; }

        public LogOnRequest(string email, string password)
        {
            if (email.IsNotEmail())
            {
                throw new ArgumentException(nameof(email));
            }

            if (password.IsNotValidPassword())
            {
                throw new ArgumentException(nameof(password));
            }

            Email = email;
            Password = password;
        }
    }
}