using System;

using Snappy.Common.Helpers;
using Snappy.Common.Models.Requests;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.Integration
{
    public class IntegrationReadListRequest : BaseRequest
    {
        public string OrganizationUid { get; }

        public IntegrationReadListRequest(string organizationUid)
        {
            if (organizationUid.IsNotUid())
            {
                throw new ArgumentException(nameof(organizationUid));
            }

            OrganizationUid = organizationUid;
        }
    }
}