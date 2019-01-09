namespace Snappy.Common.Client.Models.Requests
{
    public sealed class UserLoginLogsRequest : BaseAuthenticatedRequest
    {
        public UserLoginLogsRequest(int currentUserId) : base(currentUserId)
        {
        }
    }
}