using System;

using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.Integration.Client.Token
{
    public class IntegrationTokenRevokeRequest
    {
        public string TokenUid { get; }

        public IntegrationTokenRevokeRequest(string tokenUid)
        {
            if (tokenUid.IsNotUid())
            {
                throw new ArgumentException(nameof(tokenUid));
            }

            TokenUid = tokenUid;
        }
    }
}