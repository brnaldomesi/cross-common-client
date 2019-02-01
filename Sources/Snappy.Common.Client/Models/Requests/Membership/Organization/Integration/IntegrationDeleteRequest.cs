using Snappy.Common.Client.Models.Requests.Membership.Organization.Integration.Base;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.Integration
{
    public class IntegrationDeleteRequest : IntegrationBaseRequest
    {
        public IntegrationDeleteRequest(string integrationUid) : base(integrationUid)
        {
        }
    }
}