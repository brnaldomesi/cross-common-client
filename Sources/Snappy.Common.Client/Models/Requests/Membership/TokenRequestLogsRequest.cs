namespace Snappy.Common.Client.Models.Requests.Membership
{
    public sealed class TokenRequestLogsRequest : BaseAuthenticatedRequest
    {
        public TokenRequestLogsRequest(int currentUserId) : base(currentUserId)
        {
        }
    }
}