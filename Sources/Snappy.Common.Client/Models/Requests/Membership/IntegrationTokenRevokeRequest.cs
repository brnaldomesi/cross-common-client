namespace Snappy.Common.Client.Models.Requests.Membership
{
    public class IntegrationTokenRevokeRequest : IntegrationTokenBaseRequest
    {
        public IntegrationTokenRevokeRequest(string integrationUid, string tokenUid) : base(integrationUid, tokenUid)
        {
        }
    }
}