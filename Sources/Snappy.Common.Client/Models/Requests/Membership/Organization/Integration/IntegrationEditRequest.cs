using System;

using Snappy.Common.Helpers;
using Snappy.Common.Models.Requests;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.Integration
{
    public class IntegrationEditRequest : BaseRequest
    {
        public string IntegrationUid { get; }
        public string IntegrationName { get; }
        public string Description { get; }

        public IntegrationEditRequest(string integrationUid, string integrationName, string description)
        {
            if (integrationUid.IsNotUid())
            {
                throw new ArgumentException(nameof(integrationUid));

            }

            if (integrationName.IsEmpty())
            {
                throw new ArgumentException(nameof(integrationName));
            }

            IntegrationUid = integrationUid;
            IntegrationName = integrationName;
            Description = description;
        }
    }
}