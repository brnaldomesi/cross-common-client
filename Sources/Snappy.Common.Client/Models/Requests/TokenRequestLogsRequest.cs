namespace Snappy.Common.Client.Models.Requests
{
    public sealed class TokenRequestLogsRequest : BaseAuthenticatedRequest
    {
        public TokenRequestLogsRequest(int currentUserId) : base(currentUserId)
        {
        }
    }
}