using System;

using Snappy.Common.Helpers;
using Snappy.Common.Models.Requests;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.User
{
    public sealed class SignUpRequest : BaseRequest
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public string OrganizationUid { get; }
        public string Password { get; }

        public SignUpRequest(string firstName, string lastName, string organizationUid, string email, string password)
        {
            if (firstName.IsEmpty())
            {
                throw new ArgumentException(nameof(firstName));
            }

            if (lastName.IsEmpty())
            {
                throw new ArgumentException(nameof(lastName));
            }

            if (organizationUid.IsNotUid())
            {
                throw new ArgumentException(nameof(organizationUid));
            }

            if (email.IsNotEmail())
            {
                throw new ArgumentException(nameof(email));
            }

            if (password.IsNotValidPassword())
            {
                throw new ArgumentException(nameof(password));
            }

            FirstName = firstName;
            LastName = lastName;
            OrganizationUid = organizationUid;
            Email = email;
            Password = password;
        }
    }
}