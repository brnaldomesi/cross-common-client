using Snappy.Common.Client.Models.Requests.Membership.Organization.Integration.Base;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.Integration
{
    public class IntegrationReadRequest : IntegrationBaseRequest
    {
        public IntegrationReadRequest(string integrationUid) : base(integrationUid)
        {
        }
    }
}