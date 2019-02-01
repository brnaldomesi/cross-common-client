using Snappy.Common.Client.Models.Requests.Membership.Organization.Base;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization
{
    public class OrganizationUserLoginLogsRequest : OrganizationBaseRequest
    {
        public OrganizationUserLoginLogsRequest(string organizationUid) : base(organizationUid)
        {
        }
    }
}