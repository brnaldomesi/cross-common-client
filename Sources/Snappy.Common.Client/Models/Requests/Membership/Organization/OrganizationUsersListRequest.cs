using Snappy.Common.Client.Models.Requests.Membership.Organization.Base;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization
{
    public class OrganizationUsersListRequest : OrganizationBaseRequest
    {
        public OrganizationUsersListRequest(string organizationUid) : base(organizationUid)
        {
        }
    }
}