namespace Snappy.Common.Client.Models.Requests
{
    public sealed class PermissionLogsRequest : BaseAuthenticatedRequest
    {
        public PermissionLogsRequest(int currentUserId) : base(currentUserId)
        {
        }
    }
}