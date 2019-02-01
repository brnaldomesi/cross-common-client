using Snappy.Common.Client.Models.Requests.Membership.Organization.Base;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization
{
    public class OrganizationIntegrationsListRequest : OrganizationBaseRequest
    {
        public OrganizationIntegrationsListRequest(string organizationUid) : base(organizationUid)
        {
        }
    }
}