namespace Snappy.Common.Client.Models.Requests.Membership
{
    public sealed class PermissionLogsRequest : BaseAuthenticatedRequest
    {
        public PermissionLogsRequest(int currentUserId) : base(currentUserId)
        {
        }
    }
}