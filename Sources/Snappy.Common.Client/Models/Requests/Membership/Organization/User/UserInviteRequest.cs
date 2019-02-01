﻿using System;

using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.User
{
    public sealed class UserInviteRequest : BaseAuthenticatedRequest
    {
        public string Email { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public UserInviteRequest(int currentUserId, string email, string firstName, string lastName) : base(currentUserId)
        {
            if (email.IsNotEmail())
            {
                throw new ArgumentException(nameof(email));
            }

            if (firstName.IsEmpty())
            {
                throw new ArgumentException(nameof(firstName));
            }

            if (lastName.IsEmpty())
            {
                throw new ArgumentException(nameof(lastName));
            }

            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
