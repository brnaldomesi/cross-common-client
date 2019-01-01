using System;

using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.Requests
{
    public sealed class UserChangePasswordRequest : BaseAuthenticatedRequest
    {
        public string OldPassword { get; }
        public string NewPassword { get; }

        public UserChangePasswordRequest(int currentUserId, string oldPassword, string newPassword) : base(currentUserId)
        {
            if (oldPassword.IsNotValidPassword())
            {
                throw new ArgumentException(nameof(oldPassword));
            }

            if (newPassword.IsNotValidPassword())
            {
                throw new ArgumentException(nameof(newPassword));
            }

            OldPassword = oldPassword;
            NewPassword = newPassword;
        }
    }
}
