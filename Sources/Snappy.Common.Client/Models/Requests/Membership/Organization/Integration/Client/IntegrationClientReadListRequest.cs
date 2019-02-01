using Snappy.Common.Client.Models.Requests.Membership.Organization.Integration.Base;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.Integration.Client
{
    public class IntegrationClientReadListRequest : IntegrationBaseRequest
    {
        public IntegrationClientReadListRequest(string integrationUid) : base(integrationUid)
        {
        }
    }
}