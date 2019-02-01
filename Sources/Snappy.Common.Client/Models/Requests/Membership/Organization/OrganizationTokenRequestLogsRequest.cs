using Snappy.Common.Client.Models.Requests.Membership.Organization.Base;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization
{
    public class OrganizationTokenRequestLogsRequest : OrganizationBaseRequest
    {
        public OrganizationTokenRequestLogsRequest(string organizationUid) : base(organizationUid)
        {
        }
    }
}