using System;

using Snappy.Common.Helpers;
using Snappy.Common.Models.Requests;

namespace Snappy.Common.Client.Models.Requests
{
    public sealed class UserAcceptInviteRequest : BaseRequest
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Password { get; }

        public UserAcceptInviteRequest(string firstName, string lastName, string password)
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

            FirstName = firstName;
            LastName = lastName;
            Password = password;
        }
    }
}
