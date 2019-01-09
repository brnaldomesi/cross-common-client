namespace Snappy.Common.Client.Models.Requests
{
    public sealed class PermissionLogs : BaseAuthenticatedRequest
    {
        public PermissionLogs(int currentUserId) : base(currentUserId)
        {
        }
    }
}