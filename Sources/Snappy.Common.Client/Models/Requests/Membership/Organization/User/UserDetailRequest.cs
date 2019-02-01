using System;

using Snappy.Common.Helpers;
using Snappy.Common.Models.Requests;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.User
{
    public sealed class UserDetailRequest : BaseRequest
    {
        public string UserUid { get; }

        public UserDetailRequest(string userUid)
        {
            if (userUid.IsNotUid())
            {
                throw new ArgumentException(nameof(userUid));
            }

            UserUid = userUid;
        }
    }
}