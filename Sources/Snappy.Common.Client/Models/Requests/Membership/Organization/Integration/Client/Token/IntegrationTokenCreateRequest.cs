using System;

using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.Integration.Client.Token
{
    public class IntegrationTokenCreateRequest
    {
        public string ClientUId { get; }
        public string ClientSecret { get; }

        public IntegrationTokenCreateRequest(string clientUId, string clientSecret)
        {
            if (clientUId.IsNotUid())
            {
                throw new ArgumentException(nameof(clientUId));
            }

            if (clientSecret.IsEmpty())
            {
                throw new ArgumentException(nameof(clientSecret));
            }

            ClientUId = clientUId;
            ClientSecret = clientSecret;
        }
    }
}