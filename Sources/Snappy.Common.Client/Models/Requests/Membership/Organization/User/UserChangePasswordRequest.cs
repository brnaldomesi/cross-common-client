using System;

using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.User
{
    public sealed class UserChangePasswordRequest : BaseAuthenticatedRequest
    {
        public string OldPassword { get; }
        public string NewPassword { get; }
        public string ReEnterNewPassword { get; }

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

            if (reEnterNewPassword.IsNotValidPassword())
            {
                throw new ArgumentException(nameof(reEnterNewPassword));
            }

            if (newPassword != reEnterNewPassword)
            {
                throw new ArgumentException("new_password_and_re_entered_password_does_not_match",
                                            nameof(newPassword));
            }

            OldPassword = oldPassword;
            NewPassword = newPassword;
            ReEnterNewPassword = reEnterNewPassword;
        }
    }
}
