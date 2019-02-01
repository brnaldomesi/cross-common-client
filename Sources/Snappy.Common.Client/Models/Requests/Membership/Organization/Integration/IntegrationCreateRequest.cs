using System;

using Snappy.Common.Helpers;
using Snappy.Common.Models.Requests;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.Integration
{
    public class IntegrationCreateRequest : BaseRequest
    {
        public string IntegrationName { get; }
        public string Description { get; }

        public IntegrationCreateRequest(string integrationName, string description)
        {
            if (integrationName.IsEmpty())
            {
                throw new ArgumentException(nameof(integrationName));
            }

            IntegrationName = integrationName;
            Description = description;
        }
    }
}