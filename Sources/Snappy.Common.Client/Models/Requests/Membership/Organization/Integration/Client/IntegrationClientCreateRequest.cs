using System;

using Snappy.Common.Client.Models.Requests.Membership.Organization.Integration.Base;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.Integration.Client
{
    public sealed class IntegrationClientCreateRequest : IntegrationBaseRequest
    {
        public string Secret { get; }

        public IntegrationClientCreateRequest(string integrationUid, string secret) : base(integrationUid)
        {
            if (secret.IsEmpty())
            {
                throw new ArgumentException(nameof(secret));
            }

            Secret = secret;
        }
    }
}
