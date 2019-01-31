using System;

using Snappy.Common.Helpers;
using Snappy.Common.Models.Requests;

namespace Snappy.Common.Client.Models.Requests.Membership
{
    public sealed class DemandPasswordResetRequest : BaseRequest
    {
        public string Email { get; }

        public DemandPasswordResetRequest(string email)
        {
            if (email.IsNotEmail())
            {
                throw new ArgumentException(nameof(email));
            }

            Email = email;
        }
    }
}
