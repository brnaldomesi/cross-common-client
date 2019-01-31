namespace Snappy.Common.Client.Models.Requests.Membership
{
    public sealed class UserLoginLogsRequest : BaseAuthenticatedRequest
    {
        public UserLoginLogsRequest(int currentUserId) : base(currentUserId)
        {
        }
    }
}