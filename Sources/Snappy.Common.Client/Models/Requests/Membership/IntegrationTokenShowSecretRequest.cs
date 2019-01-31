namespace Snappy.Common.Client.Models.Requests.Membership
{
    public class IntegrationTokenShowSecretRequest : IntegrationTokenBaseRequest
    {
        public IntegrationTokenShowSecretRequest(string integrationUid, string tokenUid) : base(integrationUid, tokenUid)
        {
        }
    }
}