using Snappy.Common.Client.Models.Requests.Membership.Organization.Integration.Base;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization.Integration
{
    public class IntegrationUserLoginLogsRequest : IntegrationBaseRequest
    {
        public IntegrationUserLoginLogsRequest(string integrationUid) : base(integrationUid)
        {
        }
    }
}