using System;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.Integration.Client.Base
{
    public class IntegrationClientBaseRequest
    {
        public string ClientUid { get; }

        public IntegrationClientBaseRequest(string clientUid)
        {
            if (clientUid.IsNotUid())
            {
                throw new ArgumentException(nameof(clientUid));
            }

            ClientUid = clientUid;
        }
    }
}