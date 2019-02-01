using System;

using Snappy.Common.Helpers;
using Snappy.Common.Models.Requests;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.Integration.Base
{
    public class IntegrationBaseRequest : BaseRequest
    {
        public string IntegrationUid { get; }

        public IntegrationBaseRequest(string integrationUid)
        {
            if (integrationUid.IsNotUid())
            {
                throw new ArgumentException(nameof(integrationUid));
            }

            IntegrationUid = integrationUid;
        }
    }
}