using System;

using Snappy.Common.Helpers;
using Snappy.Common.Models.Requests;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.Base
{
    public class OrganizationBaseRequest : BaseRequest
    {
        public string OrganizationUid { get; }

        public OrganizationBaseRequest(string organizationUid)
        {
            if (organizationUid.IsNotUid())
            {
                throw new ArgumentException(nameof(organizationUid));
            }

            OrganizationUid = organizationUid;
        }
    }
}