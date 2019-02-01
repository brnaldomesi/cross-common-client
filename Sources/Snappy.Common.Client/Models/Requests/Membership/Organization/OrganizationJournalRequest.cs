using Snappy.Common.Client.Models.Requests.Membership.Organization.Base;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization
{
    public class OrganizationJournalRequest : OrganizationBaseRequest
    {
        public OrganizationJournalRequest(string organizationUid) : base(organizationUid)
        {
        }
    }
}