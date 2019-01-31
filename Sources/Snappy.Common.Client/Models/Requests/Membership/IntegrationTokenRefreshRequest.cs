namespace Snappy.Common.Client.Models.Requests.Membership
{
    public class IntegrationTokenRefreshRequest : IntegrationTokenBaseRequest
    {
        public IntegrationTokenRefreshRequest(string integrationUid, string tokenUid) : base(integrationUid, tokenUid)
        {
        }
    }
}