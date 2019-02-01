using Snappy.Common.Client.Models.Requests.Membership.Organization.Base;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization
{
    public class OrganizationReadRequest : OrganizationBaseRequest
    {
        public OrganizationReadRequest(string organizationUid) : base(organizationUid)
        {
        }
    }
}
